using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HCSAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedObjects.Commons;
using SharedObjects.StoredProcedure;
using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DebugController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public DebugController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet("GetRawData/{wcId}")]
        public async Task<List<VRawData>> GetRawDataByWC(int wcId)
        {
            var result = await context.Query<VRawData>().AsNoTracking().FromSql(SPDebug.RawData_getbyCust, wcId).ToListAsync();
            return result;
        }
        [HttpPost("addRawData")]
        public async Task<IActionResult> AddRawData([FromBody] AddRawDataViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPDebug.RawData_add, model.CustId, model.ShiftId, model.WorkingEfficiency, model.ForecastedVolume, model.WorkingDayPerMonth, model.WorkingHourPerShift, model.Coverage, model.UpdatedBy);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {

                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
        [HttpPost("UpdateRawData")]
        public async Task<IActionResult> UpdateRawData([FromBody] AddRawDataViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPDebug.RawData_update, model.CustId, model.MonthId, model.ShiftId, model.WorkingEfficiency, model.ForecastedVolume, model.WorkingDayPerMonth, model.WorkingHourPerShift, model.Coverage, model.UpdatedBy);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
        [HttpGet("getactive/{wcId}")]
        public async Task<List<VDebugData>> GetDebugDataByWC(int wcId)
        {
            var results = await context.Query<VDebugData>().AsNoTracking().FromSql(SPDebug.Debug_getallactive, wcId).ToListAsync();
            return results;
        }
        [HttpPost("UpdateDebugData")]
        public async Task<IActionResult> UpdateDebug([FromBody] DebugDataViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPDebug.Debug_Data_update, model.Id, model.Station, model.HardcoreRate, model.TimeForHardcoreBoard, model.TimeForNormalBoard, model.FinalYield, model.HitrateYield, model.RetestPassYield, model.RMA, model.UpdatedBy);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
        [HttpPost("AddDebugData")]
        public async Task<IActionResult> AddDebugData([FromBody] DebugDataViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPDebug.Debug_Data_add, model.CustId, model.Station, model.HardcoreRate, model.TimeForHardcoreBoard, model.TimeForNormalBoard, model.FinalYield, model.HitrateYield, model.RetestPassYield, model.RMA, model.UpdatedBy);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
        [HttpPost("delete")]
        public async Task<IActionResult> Delete([FromBody] DebugDataViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPDebug.Debug_Data_delete, model.Id);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
        [HttpGet("getresult/{wcId}")]
        public async Task<List<VDebugResult>> GetDebugResult(int wcId)
        {
            var results = await context.Query<VDebugResult>().AsNoTracking().FromSql(SPDebug.Result_get, wcId).ToListAsync();
            return results;
        }
        [HttpPost("UpdateDebugTech")]
        public async Task<IActionResult> UpdateTestTech([FromBody] UpdateHeadcountViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPDebug.HeadCount_update, model.CustId, model.Sep, model.Oct, model.Nov, model.Dec, model.Jan, model.Feb, model.Mar, model.Apr, model.May, model.Jun, model.Jul, model.Aug, model.UpdatedBy);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
    }
}