using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;
using Microsoft.AspNetCore.Authorization;
using OfficeOpenXml;
using Microsoft.AspNetCore.Hosting;
using Syroot.Windows.IO;
using ClosedXML.Excel;
using System.Text;
using System.Reflection.PortableExecutable;
using System.DirectoryServices;

namespace HCSizing.Controllers
{
    public class DebugController : Controller
    {
        private readonly IDebugService debugService;
        private readonly IAdminService adminService;
        private readonly IHostingEnvironment hostingEnvironment;

        public DebugController(IDebugService debugService, IAdminService adminService, IHostingEnvironment hostingEnvironment)
        {
            this.debugService = debugService;
            this.adminService = adminService;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Search()
        {
            var WCs = await debugService.GetAllAsync();
            ViewData["WCs"] = WCs;

            var userId = User.Identity.Name;
            var id = userId.Split("\\");
            var displayName = FindName(id[1]);
            ViewData["displayName"] = displayName;
         
            var userRole = await adminService.User_Role_SelectAsync(id[1]);
            ViewData["userRole"] = userRole;
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> AddDebugData()
        {
            var WCs = await debugService.GetAllAsync();
            ViewData["WCs"] = WCs;

            return View();
        }


        [HttpGet]
        public async Task<IActionResult> AddDebugRawData()
        {
            var WCs = await debugService.GetAllAsync();
            ViewData["WCs"] = WCs;

            var userId = User.Identity.Name;
            var id = userId.Split("\\");
            ViewData["Id"] = id[1];
            var displayName = FindName(id[1]);
            ViewData["displayName"] = displayName;

            return View();
        }
        public async Task<IActionResult> AddDebugRawData(AddDebugRawDataViewModel model)
        {

            if (ModelState.IsValid)
            {

                var result = await debugService.AddDebugRawData(model);
                if (result.StatusCode == 200)
                {
                    //return Redirect("/debug/search");
                    return Redirect("http://vnhcmm0teapp02/hcs");
                }
                else
                {
                    foreach (var item in result.Notification)
                    {
                        ModelState.AddModelError("", item);
                    }
                    var WCs = await debugService.GetAllAsync();
                    ViewData["WCs"] = WCs;

                    var userId = User.Identity.Name;
                    var id = userId.Split("\\");
                    ViewData["Id"] = id[1];
                    var displayName = FindName(id[1]);
                    ViewData["displayName"] = displayName;

                    return View(model);
                }
            }
            else
            {
                var WCs = await debugService.GetAllAsync();
                ViewData["WCs"] = WCs;

                var userId = User.Identity.Name;
                var id = userId.Split("\\");
                ViewData["Id"] = id[1];
                var displayName = FindName(id[1]);
                ViewData["displayName"] = displayName;

                return View(model);
            }

        }
        public async Task<IActionResult> AddDebugData(AddDebugDataViewModel model)
        {
            if (ModelState.IsValid)
            {

                var result = await debugService.AddDebugDataAsync(model);
                if (result.StatusCode == 200)
                {
                    return Redirect("/debug/search");
                    //return Redirect("http://vnhcmm0teapp02/imageapp");
                }
                else
                {
                    foreach (var item in result.Notification)
                    {
                        ModelState.AddModelError("", item);
                    }
                    var WCs = await debugService.GetAllAsync();
                    ViewData["WCs"] = WCs;
                    return View(model);
                }
            }
            else
            {
                var WCs = await debugService.GetAllAsync();
                ViewData["WCs"] = WCs;
                return View(model);
            }

        }
        public async Task<IActionResult> UpdateDebugRawData([FromBody] AddDebugRawDataViewModel model)
        {
            var result = await debugService.UpdateDebugRawData(model);
            return Json(new { statusCode = result.StatusCode });
        }
        public async Task<IActionResult> AddDebugDataBody([FromBody] AddDebugDataViewModel model)
        {
            var result = await debugService.AddDebugDataAsync(model);
            return Json(new { statusCode = result.StatusCode });
        }
      
        public async Task<IActionResult> GetDebugRawDataByWC_partialview(string wc)
        {
            var debugrawdata = await debugService.GetDebugRawDataByWCAsync(wc);           
            return PartialView(debugrawdata);
        }
        public async Task<IActionResult> GetDebugResult(string wc)
        {
            var debugresult = await debugService.GetDebugResultAsync(wc);

            return Json(new { result = debugresult });
        }
        public async Task<IActionResult> GetDebugResult_partialview(string wc)
        {
            var debugresult = await debugService.GetDebugResultAsync(wc);
            var lstMonths = new List<string>() { "Sep", "Oct", "Nov", "Dec", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug" };
            ViewData["Months"] = lstMonths;
            return PartialView(debugresult);
        }
      
        public async Task<IActionResult> UpdateDebug([FromBody] UpdateSingleDebugDataByIdViewModel model)
        {
            var result = await debugService.UpdateDebugAsync(model);
            return Json(new { statusCode = result.StatusCode });
        }
        public async Task<IActionResult> GetDebugDataByWC(string wc)
        {
            var debugdata = await debugService.GetDebugDataByWCAsync(wc);

            return Json(new { result = debugdata });
        }
     
        public async Task<IActionResult> GetDebugDataByWC_partialview(string wc)
        {
            var debugdata = await debugService.GetDebugDataByWCAsync(wc);
          
            return PartialView(debugdata);
        }
        public async Task<IActionResult> DeleteDebugDataByIdAsync([FromBody] DeleteSingleDebugDataByIdViewModel model)
        {
            var result = await debugService.DeleteDebugDataByIdAsync(model);
            return Json(new { statusCode = result.StatusCode });
        }
     
        public async Task<IActionResult> UpdateDebugTech([FromBody] UpdateLockedHeadcountViewModel model)
        {
            var result = await debugService.UpdateDebugTechAsync(model);
            return Json(new { statusCode = result.StatusCode });
        }
        public async Task<IActionResult> AddActualLockedOperatorAsync([FromBody] AddActualLoggedViewModel model)
        {
            var result = await debugService.AddActualLockedOperatorAsync(model);
            return Json(new { statusCode = result.StatusCode });
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
                return "Unknown";
            }

        }


    }
}