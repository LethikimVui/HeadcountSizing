using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using HCSAPI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SharedObjects.Commons;
using SharedObjects.StoredProcedure;
using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = "Bearer")]
    //[Authorize(Roles = "Admin")]
    public class AccountController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IConfiguration configuration;

        public AccountController(ApplicationDbContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginViewModel model)
        {
            var user = await context.Query<VUsers>().AsNoTracking().FromSql(SPAccount.User_Check, model.NTLogin).FirstOrDefaultAsync();
            if (user == null)
            {
                return NotFound(new ResponseResult(404));
            }
            else
            {
                // start create claims
                List<Claim> infomationClaim = new List<Claim>()
                    {
                        new Claim("Ntlogin", user.Ntlogin),
                        new Claim("UserName", user.UserName),
                        new Claim("RoleId", user.RoleId.ToString()),
                        new Claim("RoleName", user.RoleName),
                        new Claim("CustId", user.CustId.ToString())
                    };

                // create the calimIdentity to store these claims
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(infomationClaim);

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));

                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken
                (
                    configuration["Jwt:Issuer"],
                    configuration["Jwt:Audience"],
                    claimsIdentity.Claims,
                    expires: DateTime.UtcNow.AddDays(1),
                    signingCredentials: signIn);
                string strToken = new JwtSecurityTokenHandler().WriteToken(token);
                return Ok(new ResponseResult(200, strToken));
            }
        }
    }
}