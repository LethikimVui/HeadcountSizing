using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HCSizingAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using SharedObjects.Common;
using SharedObjects.StoreProcedure;
using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;
using Syroot.Windows.IO;

namespace HCSizingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DebugController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IHostingEnvironment hostingEnvironment;

        public DebugController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            this.context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        [HttpPost("addDebugRawData")]
        public async Task<IActionResult> AddDebugRawData([FromBody] AddDebugRawDataViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPDebug.DebugRawData_add, model.Wc, model.WorkingDayPerMonth, model.WorkingHourPerShift, model.ShiftPatten, model.WorkEfficiency, model.ForecastedVolume, model.UpdateBy, model.Coverage);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {

                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
        [HttpPost("UpdateDebugRawData")]
        public async Task<IActionResult> UpdateDebugRawData([FromBody] AddDebugRawDataViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPDebug.DebugRawData_update, model.Wc, model.MonthID, model.WorkingDayPerMonth, model.WorkingHourPerShift, model.ShiftPatten, model.WorkEfficiency, model.ForecastedVolume, model.UpdateBy, model.Coverage);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {

                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
            
        
        [HttpGet("DebugRawData_getallbyWC/{wc}")]
        public async Task<List<VDebugRawData>> GetDebugRawDataByWC(string wc)
        {
            var result = await context.Query<VDebugRawData>().AsNoTracking().FromSql(SPDebug.DebugRawData_getallbyWC, wc).ToListAsync();
            return result;
        }
        [HttpPost("addDebugData")]
        public async Task<IActionResult> AddDebugData([FromBody] AddDebugDataViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPDebug.Debug_add, model.Wc, model.Station, model.DebugHitrateYield, model.HardcoreRate, model.DebugTimeForNormalBoard, model.DebugTimeForHardcoreBoard, model.UpdateBy, model.FinalYield, model.DebugRetestPassYield, model.RMA);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {

                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }

        [HttpGet("getallactivedebugdatabywc/{wc}")]
        public async Task<List<VDebugData>> GetDebugDataByWC(string wc)
        {            
            var results = await context.Query<VDebugData>().AsNoTracking().FromSql(SPDebug.Debug_getallactive, wc).ToListAsync();
            return results;
        }      
       
        [HttpPost("UpdateDebug")]
        public async Task<IActionResult> UpdateDebug([FromBody] UpdateSingleDebugDataByIdViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPDebug.Debug_update, model.Id, model.Station, model.DebugHitrateYield, model.HardcoreRate, model.DebugTimeForNormalBoard, model.DebugTimeForHardcoreBoard, model.UpdateBy, model.FinalYield, model.DebugRetestPassYield, model.RMA);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {

                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
        [AllowAnonymous]
        [HttpDelete("deletedebugdatabyid/{id}")]
        public async Task<IActionResult> DeleteDebugDataById( int id)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPDebug.DeleteDebugDataById, id);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }

        }

        [HttpPost("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteSingleDebugDataByIdViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPDebug.DeleteDebugDataById, model.Id);
                return Ok(new ResponseResult(200));
            }

            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));

            }
        }

        [HttpGet("getdebugresult/{wc}")]
        public async Task<List<VDebugResult>> GetDebugDResult(string wc)

        {
            var results = await context.Query<VDebugResult>().AsNoTracking().FromSql(SPDebug.GetDebugResult, wc).ToListAsync();
            return results;
        }
        [HttpGet("export/{wc}")]
        public async Task<IActionResult> ExportAsync(string wc)
        {
            //string rootFolder = hostingEnvironment.ContentRootPath;
            //string downloadsPath = new KnownFolder(KnownFolderType.Downloads).Path;
            var memory = new MemoryStream();

            using (ExcelPackage package = new ExcelPackage(memory))
            {
                var results = await context.Query<VDebugResult>().AsNoTracking().FromSql(SPDebug.GetDebugResult, wc).ToListAsync();
             
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Debug"); // đặt tên sheetname
                int totalRows = results.Count();
                worksheet.Cells[1, 1].Value = "Month";
                worksheet.Cells[1, 2].Value = "ActualOP";
                worksheet.Cells[1, 3].Value = "ActualTech";
                int i = 0;
                for (int row = 2; row <= totalRows + 1; row++)
                {
                    worksheet.Cells[row, 1].Value = results[i].Month;
                    worksheet.Cells[row, 2].Value = results[i].RoundUpOP;
                    worksheet.Cells[row, 3].Value = results[i].RoundUpTech;
                    i++;
                }
                package.Save();

            }
            string excelname = $"list{DateTime.Now.ToString("yyMMddHHmmssfff")}.xlsx";
            var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";//System.Net.Mime.MediaTypeNames.Application.Octet
            //using (var stream = new FileStream(Path.Combine(downloadsPath, excelname), FileMode.CreateNew))
            //{
            //    //await stream.CopyToAsync(memory);
            //}
            memory.Position = 0;
            return File(memory, contentType, excelname);
        }



        [HttpGet("getallWC")]
        public async Task<List<VWC>> GetAllWC()
        {
            var result = await context.Query<VWC>().AsNoTracking().FromSql(SPDebug.GetAllWC).ToListAsync();
            return result;


        }

     
        [HttpPost("UpdateDebugTech")]
        public async Task<IActionResult> UpdateTestTech([FromBody] UpdateLockedHeadcountViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPDebug.CurrentHC_update_debugtech, model.WC, model.Sep, model.Oct, model.Nov, model.Dec, model.Jan, model.Feb, model.Mar, model.Apr, model.May, model.Jun, model.Jul, model.Aug, model.UpdatedBy);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
        [HttpPost("AddActualLockedOpertor")]
        public async Task<IActionResult> AddActualLockedOperatorAsync([FromBody] AddActualLoggedViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPDebug.AddActualLoggedOperator, model.WC, model.Sep, model.Oct, model.Nov, model.Dec, model.Jan, model.Feb, model.Mar, model.Apr, model.May, model.Jun, model.Jul, model.Aug);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {

                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }


     
    }
}