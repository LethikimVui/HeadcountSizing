using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HCSizingAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedObjects.Common;
using SharedObjects.StoreProcedure;
using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;

namespace HCSizingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LineSupportController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public LineSupportController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet("getallstation/{wc}")]
        public async Task<List<VStation>> GetallStation(string wc)
        {
            var results = await context.Query<VStation>().AsNoTracking().FromSql(SPTestTech.GetStationList, wc).ToListAsync();
            return results;
        }
        [HttpGet("getalldowntimedetail/{wc}")]
        public async Task<List<VDowntime>> GetAllDowntimeDetail(string wc)
        {
            var results = await context.Query<VDowntime>().AsNoTracking().FromSql(SPTestTech.Activities_get_all_downtimeDetail, wc).ToListAsync();
            return results;
        }
        [HttpPost("GetDowntimeDetailByDowntimeType")]
        public async Task<List<VDowntime>> GetDowntimeDetailByDowntimeType([FromBody] GetDowntimeViewModel model)
        {
            var results = await context.Query<VDowntime>().AsNoTracking().FromSql(SPTestTech.Master_WCDowntime_get_bydowntimetype, model.Wc, model.DowntimeType).ToListAsync();
            return results;
        }
        [HttpGet("getalldowntimebywc/{wc}")]
        public async Task<List<VActivities>> GetAllDowntimeByWC(string wc)
        {
            var results = await context.Query<VActivities>().AsNoTracking().FromSql(SPTestTech.Activities_getallbyWC, wc).ToListAsync();
            return results;
        }

        [HttpPost("getquantity")]
        public async Task<List<VEquipmentQuantity>> getquantity([FromBody] GetEquipmentQuantity model)
        {
            var results = await context.Query<VEquipmentQuantity>().AsNoTracking().FromSql(SPTestTech.get_equipment_quantity_by_Station, model.stationOrTester, model.wc).ToListAsync();
            return results;
        }
 
        [HttpPost("AddStationData")]
        public async Task<IActionResult> AddStationData([FromBody] AddStationDataViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPTestTech.equipment_add_station, model.Month, model.Station, model.Quantity, model.MonthID, model.WC, model.CreatedBy);
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
                await context.Database.ExecuteSqlCommandAsync(SPTestTech.equipment_update_station_quantity, model.Wc, model.Month, model.StationOrTester, model.Quantity, model.UpdatedBy);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
        [HttpPost("UpdateDowntime")]
        public async Task<IActionResult> UpdateDowntime([FromBody] UpdateDowntimeViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPTestTech.Activities_update, model.Wc, model.DowntimeType, model.DowntimeDetail, model.StationOrTester, model.Duration, model.UpdatedBy);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }
        [HttpPost("UpdateTestTech")]
        public async Task<IActionResult> UpdateTestTech([FromBody] UpdateLockedHeadcountViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPTestTech.CurrentHC_update_testtech, model.WC, model.Sep, model.Oct, model.Nov, model.Dec, model.Jan, model.Feb, model.Mar, model.Apr, model.May, model.Jun, model.Jul, model.Aug, model.UpdatedBy);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }
        }

        [HttpGet("getfinalresult/{wc}")]
        public async Task<List<VTestResult>> GetFinalResult(string wc)
        {
            var results = await context.Query<VTestResult>().AsNoTracking().FromSql(SPTestTech.GetFinalResult, wc).ToListAsync();
            return results;
        }

    }
}