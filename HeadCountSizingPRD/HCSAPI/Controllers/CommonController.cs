using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HCSAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedObjects.StoreProcedure;
using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public CommonController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet("getWC/{WCId}")]
        public async Task<List<VCustomer>> GetAllWC(int WCId)
        {
            var result = await context.Query<VCustomer>().AsNoTracking().FromSql(SPCommon.GetWC, WCId).ToListAsync();
            return result;
        }
        [HttpGet("getWCbyntid/{Ntlogin}")]
        public async Task<List<VCustomer>> GetWC(string Ntlogin)
        {
            var result = await context.Query<VCustomer>().AsNoTracking().FromSql(SPCommon.GetWCbyNTID, Ntlogin).ToListAsync();
            return result;
        }
        [HttpGet("GetShift")]
        public async Task<List<VShift>> GetShift()
        {
            var result = await context.Query<VShift>().AsNoTracking().FromSql(SPCommon.GetShift).ToListAsync();
            return result;
        }
        [HttpPost("GetDowntimeDetailByDowntimeType_tech")]
        public async Task<List<VDowntime>> GetDowntimeDetailByDowntimeTypeTech([FromBody] GetDowntimeViewModel model)
        {
            var results = await context.Query<VDowntime>().AsNoTracking().FromSql(SPCommon.Master_Downtime_get_bydowntimetype_technician, model.CustId, model.DowntimeType).ToListAsync();
            return results;
        }
        [HttpPost("GetDowntimeDetailByDowntimeType_Op")]
        public async Task<List<VDowntime>> GetDowntimeDetailByDowntimeTypeOP([FromBody] GetDowntimeViewModel model)
        {
            var results = await context.Query<VDowntime>().AsNoTracking().FromSql(SPCommon.Master_Downtime_get_bydowntimetype_operator, model.CustId, model.DowntimeType).ToListAsync();
            return results;
        }
    }
}