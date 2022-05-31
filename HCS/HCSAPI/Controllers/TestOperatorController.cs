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
    public class TestOperatorController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public TestOperatorController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet("GetStationList/{wcId}")]
        public async Task<List<VStation>> GetallStation(int wcId)
        {
            var results = await context.Query<VStation>().AsNoTracking().FromSql(SPTestOperator.GetStationList, wcId).ToListAsync();
            return results;
        }
        [HttpPost("getquantity")]
        public async Task<List<VEquipmentQuantity>> getquantity([FromBody] GetEquipmentQuantity model)
        {
            var results = await context.Query<VEquipmentQuantity>().AsNoTracking().FromSql(SPTestOperator.Equipment_get_quantity_by_station, model.StationOrTester, model.CustId).ToListAsync();
            return results;
        }
        [HttpPost("AddStationData")]
        public async Task<IActionResult> AddStationData([FromBody] AddStationDataViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPTestOperator.Equipment_add, model.CustId, model.MonthId, model.Station, model.Quantity, model.CreatedBy);
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
                await context.Database.ExecuteSqlCommandAsync(SPTestOperator.Equipment_update, model.CustId, model.MonthId, model.StationOrTester, model.Quantity, model.UpdatedBy);
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
            var results = await context.Query<VDowntime>().AsNoTracking().FromSql(SPTestOperator.Activities_get_DowntimeTypeAndDowntimeDetail, wcId).ToListAsync();
            return results;
        }
        [HttpGet("getalldowntimebywc/{wcId}")]
        public async Task<List<VActivities>> GetAllDowntimeByWC(int wcId)
        {
            var results = await context.Query<VActivities>().AsNoTracking().FromSql(SPTestOperator.Activities_getallbyWC, wcId).ToListAsync();
            return results;
        }
        [HttpPost("UpdateDowntime")]
        public async Task<IActionResult> UpdateDowntime([FromBody] UpdateDowntimeViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPTestOperator.Activities_update, model.CustId, model.DowntimeType, model.DowntimeDetail, model.StationOrTester, model.Duration, model.UpdatedBy);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }

        [HttpGet("getfinalresult/{wcId}")]
        public async Task<List<VTestResult>> GetFinalResult(int wcId)
        {
            var results = await context.Query<VTestResult>().AsNoTracking().FromSql(SPTestOperator.GetFinalResult, wcId).ToListAsync();
            return results;
        }
        [HttpPost("UpdateTestTech")]
        public async Task<IActionResult> UpdateTestTech([FromBody] UpdateLockedHeadcountViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPTestOperator.CurrentHC_update, model.CustId, model.Sep, model.Oct, model.Nov, model.Dec, model.Jan, model.Feb, model.Mar, model.Apr, model.May, model.Jun, model.Jul, model.Aug, model.UpdatedBy);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
    }
}