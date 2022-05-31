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

namespace HCSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestTechController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public TestTechController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpPost("Equipment_GetStationList_technician")]
        public async Task<List<VStation>> GetallStation([FromBody] TestViewModel model)
        {
            var results = await context.Query<VStation>().AsNoTracking().FromSql(SPTestTech.Equipment_GetStationList_technician, model.CustId, model.FiscalYearId).ToListAsync();
            return results;
        }
        [HttpPost("getquantity")]
        public async Task<List<VEquipmentQuantity>> getquantity([FromBody] GetEquipmentQuantity model)
        {
            var results = await context.Query<VEquipmentQuantity>().AsNoTracking().FromSql(SPTestTech.Equipment_get_quantity_by_station, model.StationOrTester, model.FiscalYearId, model.CustId).ToListAsync();
            return results;
        }
        [HttpPost("Equipment_add")]
        public async Task<IActionResult> AddStationData([FromBody] AddStationDataViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPTestTech.Equipment_add, model.FiscalYearId, model.CustId, model.MonthId, model.Station, model.Quantity, model.CreatedBy);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
        [HttpPost("UpdateStationQuantity")]
        public async Task<IActionResult> UpdateStationQuantity([FromBody] UpdateStationQuantityViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPTestTech.Equipment_update, model.FiscalYearId, model.CustId, model.MonthId, model.StationOrTester, model.Quantity, model.UpdatedBy);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }

        [HttpGet("getalldowntime/{wcId}")]
        public async Task<List<VDowntime>> GetAllDowntimeDetail(int wcId)
        {
            var results = await context.Query<VDowntime>().AsNoTracking().FromSql(SPTestTech.Activities_get_DowntimeTypeAndDowntimeDetail, wcId).ToListAsync();
            return results;
        }
        [HttpPost("Activities_get_DowntimeTypeAndDowntimeDetail")]
        public async Task<List<VDowntime>> Activities_get_DowntimeTypeAndDowntimeDetail(TestViewModel model)
        {
            var results = await context.Query<VDowntime>().AsNoTracking().FromSql(SPTestTech.Activities_get_DowntimeTypeAndDowntimeDetail, model.CustId, model.FiscalYearId).ToListAsync();
            return results;
        }
        [HttpGet("getalldowntimebywc/{wcId}")]
        public async Task<List<VActivities>> GetAllDowntimeByWC(int wcId)
        {
            var results = await context.Query<VActivities>().AsNoTracking().FromSql(SPTestTech.Activities_getallbyWC, wcId).ToListAsync();
            return results;
        }
        [HttpPost("getalldowntimebywc")]
        public async Task<List<VActivities>> GetAllDowntimeByWC([FromBody] TestViewModel model)
        {
            var results = await context.Query<VActivities>().AsNoTracking().FromSql(SPTestTech.Activities_getallbyWC, model.FiscalYearId, model.CustId).ToListAsync();
            return results;
        }
        [HttpPost("UpdateDowntime")]
        public async Task<IActionResult> UpdateDowntime([FromBody] UpdateDowntimeViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPTestTech.Activities_update, model.FiscalYearId, model.CustId, model.DowntimeType, model.DowntimeDetail, model.StationOrTester, model.Duration, model.UpdatedBy);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }

        //[HttpGet("getfinalresult/{wcId}")]
        //public async Task<List<VTestResult>> GetFinalResult(int wcId)
        //{
        //    var results = await context.Query<VTestResult>().AsNoTracking().FromSql(SPTestTech.GetFinalResult, wcId).ToListAsync();
        //    return results;
        //} 
        [HttpPost("Result_test_technician_calculation")]
        public async Task<List<VTestResult>> GetFinalResult(TestViewModel model)
        {
            var results = await context.Query<VTestResult>().AsNoTracking().FromSql(SPTestTech.Result_test_technician_calculation, model.FiscalYearId, model.CustId).ToListAsync();
            return results;
        }
        [HttpPost("UpdateTestTech")]
        public async Task<IActionResult> UpdateTestTech([FromBody] UpdateLockedHeadcountViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPTestTech.CurrentHC_update, model.CustId, model.FiscalYearId, model.Sep, model.Oct, model.Nov, model.Dec, model.Jan, model.Feb, model.Mar, model.Apr, model.May, model.Jun, model.Jul, model.Aug, model.UpdatedBy);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }



        [HttpPost("Test_Equipment_add")]
        public async Task<IActionResult> Test_Equipment_add([FromBody] TestViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPTestTech.Test_Equipment_add, model.Station, model.FiscalYearId, model.CustId, model.Quantity, model.UpdatedBy);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }


    }
}