using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Threading.Tasks;
using HCSizingAPI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedObjects.StoreProcedure;
using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;

namespace HCSizingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public AdminController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet("User_Role_Select/{ntid}")]
        public async Task<VAccessUserRole> User_Role_Select(string ntid)
        {
            var result = await context.Query<VAccessUserRole>().AsNoTracking().FromSql(SPAdmin.User_Role_Select, ntid).FirstOrDefaultAsync();
            return result;
        }
        [HttpGet("User_Role_Select_All")]
        public async Task<List<VAccessUserRole>> User_Role_Select_All()
        {
            var results = await context.Query<VAccessUserRole>().AsNoTracking().FromSql(SPAdmin.User_Role_Select_All).ToListAsync();
            return results;
        }
        [HttpGet]
        [Route("authenticateuser/{username}/{password}")]
        public bool ADUserExists(string userName, string password)
        {
            bool valid = false;
            using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
            {
                valid = context.ValidateCredentials(userName, password);
            }
            return valid;
        }
    }
}