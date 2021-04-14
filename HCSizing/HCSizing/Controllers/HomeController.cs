using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HCSizing.Models;
using System.DirectoryServices;
using SharedObjects.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.DirectoryServices.AccountManagement;
using Services.Interfaces;
using Services.Services;

namespace HCSizing.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDebugService debugService;
        private readonly IAdminService adminService;
        private readonly ITestTechService testTechService;

        public HomeController(IDebugService debugService, IAdminService adminService, ITestTechService testTechService)
        {
            this.debugService = debugService;
            this.adminService = adminService;
            this.testTechService = testTechService;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            bool check = ADUserExists(model.NTID, model.Password);
            if (check)
            {
                //return Redirect("/debug/search");
                return Redirect("http://vnhcmm0teapp02/hcs/debug/search");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Sai tên đăng nhập hoặc mật khẩu!");
                return View(model);
            }
        }



        public IActionResult About()
        {
            
            var userId = User.Identity.Name;
            var id = userId.Split("\\");
            var displayName = FindName(id[1]);
            ViewData["displayName"] = displayName;

            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            return Redirect("/Home/Login");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        bool ADUserExists(string userName, string password)
        {
            bool valid = false;
            using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
            {
                valid = context.ValidateCredentials(userName, password);
            }
            return valid;
        }
       
        string FindName(string ntid)
        {
            var myentry = new System.DirectoryServices.DirectoryEntry();
            var mysearcher = new DirectorySearcher(myentry);
            mysearcher.Filter = "(&(objectCategory=person)(objectClass=user)(sAMAccountName=" + ntid + "))";
            var result = mysearcher.FindOne();

            if (result.Properties.Contains("displayName"))
            {
                string displayName = result.Properties["displayName"][0].ToString();
                return displayName;
            }
            else
            {
                return "Name Not Found";
            }

        }

        string FindEmail(string ntid)
        {
            var de = new System.DirectoryServices.DirectoryEntry();
            var ds = new DirectorySearcher(de);
            ds.Filter = "(&(objectCategory=person)(objectClass=user)(sAMAccountName=" + ntid + "))";
            var result = ds.FindOne();

            if (result.Properties.Contains("displayName"))
            {
                string mail = result.Properties["mail"][0].ToString();
                return mail;
            }
            else
            {
                return "Email Not Found";
            }

        }
        
        public async Task<IActionResult> PopulationChart(string wc)
        {
            var debugresult = await debugService.GetDebugResultAsync(wc);
            return Json(debugresult);
        }

        public async Task<IActionResult> GetAllColumnName()
        {
            string wc = "hcm_swi";
            var result = await testTechService.GetallStation(wc);

            return View(result);
        }
        public async Task<IActionResult> GetQuantity(GetEquipmentQuantity model)
        {
            //string wc = "hcm_swi";
            var result = await testTechService.EquipmentQuantityAsync(model);
            return Json(result);
        }
        public async Task<IActionResult> GetAllColumnNameJson()
        {
            string wc = "hcm_swi";
            var result = await testTechService.GetallStation(wc);
            return Json(result);
        }
    }
}
