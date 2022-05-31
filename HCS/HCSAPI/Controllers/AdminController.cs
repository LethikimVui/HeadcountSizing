using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HCSAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SharedObjects.Commons;
using SharedObjects.StoredProcedure;
using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;

namespace HCSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IConfiguration configuration;

        public AdminController(ApplicationDbContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }
        [HttpGet("getall")]
        public async Task<List<VAccessUserRole>> GetAll()
        {
            var results = await context.Query<VAccessUserRole>().AsNoTracking().FromSql(SPAdmin.Access_UserRole_get).ToListAsync();
            return results;
        }
        [HttpGet("getbyNTlogin/{Ntlogin}")]
        public async Task<VAccessUserRole> GetbyNTlogin(string Ntlogin)
        {
            var results = await context.Query<VAccessUserRole>().AsNoTracking().FromSql(SPAdmin.Access_UserRole_get_byNTLogin, Ntlogin).FirstOrDefaultAsync();
            return results;
        }
        [HttpGet("getrole")]
        public async Task<List<VRole>> GetRole()
        {
            var results = await context.Query<VRole>().AsNoTracking().FromSql(SPAdmin.Access_Role_select).ToListAsync();
            return results;
        }
        [HttpPost("AddUserRole")]
        public async Task<IActionResult> AddUserRole(AddUserRoleViewModel model)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPAdmin.Access_UserRole_add, model.Ntlogin, model.UserName, model.RoleId, model.PlantId, model.CustId, model.CreatedBy);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }

        }
        [HttpGet("DeleteUserRole/{roleId}/{updatedBy}")]
        public async Task<IActionResult> DeleteUserRole(int roleId, string updatedBy)
        {
            try
            {
                await context.Database.ExecuteSqlCommandAsync(SPAdmin.Access_UserRole_delete, roleId, updatedBy);
                return Ok(new ResponseResult(200));
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseResult(400, ex.Message));
            }

        }
    }
}