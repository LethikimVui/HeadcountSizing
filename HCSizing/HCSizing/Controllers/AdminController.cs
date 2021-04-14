using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace HCSizing.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService adminService;

        public AdminController(IAdminService adminService)
        {
            this.adminService = adminService;
        }
        public async Task<IActionResult> GetAllUserRole_partialview(string ntid = "1099969")
        {
            var userRole = await adminService.User_Role_SelectAsync(ntid);
            return PartialView(userRole);
        }
        public async Task<IActionResult> GetAllUserRole()
        {
            var userRoles = await adminService.User_Role_Select_AllAsync();
            return View(userRoles);
        }
    }
}