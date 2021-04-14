using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using SharedObjects.ViewModels;

namespace HCSizing.Controllers
{
    public class TestTechController : Controller
    {
        private readonly ITestTechService testTechService;
        private readonly IDebugService debugService;

        public TestTechController(ITestTechService testTechService, IDebugService debugService)
        {
            this.testTechService = testTechService;
            this.debugService = debugService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Search()
        {
            var WCs = await debugService.GetAllAsync();
            ViewData["WCs"] = WCs;
            var userId = User.Identity.Name;
            var id = userId.Split("\\");
            var displayName = FindName("displayName", id[1]);
            ViewData["displayName"] = displayName;

            return View();
        }
        public async Task<IActionResult> GetFinalResult_partialview(string wc)
        {
            var testResult = await testTechService.GetFinalResultAsync(wc);
            var lstMonths = new List<string>() { "Sep", "Oct", "Nov", "Dec", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug" };
            ViewData["Months"] = lstMonths;
            return PartialView(testResult);
        }
        public async Task<IActionResult> GetTestData(string wc)
        {

            var result = await testTechService.GetallStation(wc);
            var downtimeDetail = await testTechService.GetallDowntimeDetailAsync(wc);
            ViewData["downtimeDetail"] = downtimeDetail;
            return PartialView(result);
        }

        public async Task<IActionResult> GetDowntimeDetailByDowntimeType([FromBody] GetDowntimeViewModel model)
        {
            var downtimeDetail = await testTechService.GetDowntimeDetailByDowntimeTypeAsync(model);
            return Json(new { result = downtimeDetail });
        }
        public async Task<IActionResult> GetAllDowntimeByWC(string wc)
        {
            var test = await testTechService.GetAllDowntimeByWC(wc);
            return Json(new { result = test });
        }
        public async Task<IActionResult> GetallStation(string wc)
        {
            var stations = await testTechService.GetallStation(wc);
            return Json(new { result = stations });
        }
        public async Task<IActionResult> EquipmentQuantity([FromBody] GetEquipmentQuantity model)
        {
            var quantity = await testTechService.EquipmentQuantityAsync(model);
            return Json(new { result = quantity });
        }
        public async Task<IActionResult> AddStationData([FromBody] AddStationDataViewModel model)
        {
            var result = await testTechService.AddStationDataAsync(model);
            return Json(new { statusCode = result.StatusCode });
        }
        public async Task<IActionResult> UpdateStationQuantity([FromBody] UpdateStationQuantityViewModel model)
        {
            var result = await testTechService.UpdateStationQuantityAsync(model);
            return Json(new { statusCode = result.StatusCode });
        }
       
        public async Task<IActionResult> UpdateTestTech([FromBody] UpdateLockedHeadcountViewModel model)
        {
            var result = await testTechService.UpdateTestTechAsync(model);
            return Json(new { statusCode = result.StatusCode });
        }
        public async Task<IActionResult> UpdateDowntime([FromBody] UpdateDowntimeViewModel model)
        {
            var result = await testTechService.UpdateDowntime(model);
            return Json(new { statusCode = result.StatusCode });
        }   
        string FindName(string info, string ntid)
        {
            var myentry = new System.DirectoryServices.DirectoryEntry();
            var mysearcher = new DirectorySearcher(myentry);
            mysearcher.Filter = "(&(objectCategory=person)(objectClass=user)(sAMAccountName=" + ntid + "))";
            var result = mysearcher.FindOne();

            if (result.Properties.Contains(info))
            {
                string displayName = result.Properties[info][0].ToString();
                return displayName;
            }
            else
            {
                return "Unknown";
            }

        }
    }
}