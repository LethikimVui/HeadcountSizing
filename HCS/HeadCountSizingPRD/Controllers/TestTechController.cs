using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using SharedObjects.Extensions;
using Services.Interfaces;
using SharedObjects.ViewModels;

namespace HeadCountSizingPRD.Controllers
{
    public class TestTechController : Controller
    {
        private readonly ICommonService commonService;
        private readonly ITestTechService testTechService;

        public TestTechController(ICommonService commonService, ITestTechService testTechService)
        {
            this.commonService = commonService;
            this.testTechService = testTechService;
        }
        public async Task<IActionResult> Search()
        {
            var token = User.GetSpecificClaim("token");

            string Ntlogin = User.GetSpecificClaim("Ntlogin");
            var WCs = await commonService.GetWCByNTIDAsync(Ntlogin, token);
            var FY = await commonService.Master_FiscalYear_get();

            ViewData["WCs"] = WCs;
            ViewData["FY"] = FY;

            return View();
        }
        //public async Task<IActionResult> DataTable(int wcId)
        //{
        //    var token = User.GetSpecificClaim("token");

        //    var result = await testTechService.GetallStationAsync(wcId, token);
        //    var downtimeDetail = await testTechService.GetDowntimeTypeAndDowntimeDetailAsync(wcId);
        //    ViewData["downtimeDetail"] = downtimeDetail;
        //    return PartialView(result);
        //}  
        public async Task<IActionResult> DataTable([FromBody] TestViewModel model)
        {
            var token = User.GetSpecificClaim("token");

            var result = await testTechService.Equipment_GetStationList_technician(model);
            var downtimeDetail = await testTechService.Activities_get_DowntimeTypeAndDowntimeDetail(model);
            ViewData["downtimeDetail"] = downtimeDetail;
            return PartialView(result);
        }
        //public async Task<IActionResult> GetallStation(int wcId)
        //{
        //    var token = User.GetSpecificClaim("token");

        //    var stations = await testTechService.GetallStationAsync(wcId, token);
        //    return Json(new { result = stations });
        //}
        public async Task<IActionResult> GetallStation([FromBody] TestViewModel model)
        {          
            var stations = await testTechService.Equipment_GetStationList_technician(model);
            return Json(new { result = stations });
        }
        public async Task<IActionResult> GetEquipmentQuantity([FromBody] GetEquipmentQuantity model)
        {
            var token = User.GetSpecificClaim("token");

            var quantity = await testTechService.GetEquipmentQuantityAsync(model, token);
            return Json(new { result = quantity });
        }
        public async Task<IActionResult> AddStationData([FromBody] AddStationDataViewModel model)
        {
            //var token = User.GetSpecificClaim("token");

            var result = await testTechService.Equipment_add(model);
            return Json(new { statusCode = result.StatusCode });
        }
        //public async Task<IActionResult> GetDowntimeDetailByDowntimeType([FromBody] GetDowntimeViewModel model)
        //{
        //    var downtimeDetail = await commonService.GetDowntimeDetailByDowntimeTypeTechAsync(model);
        //    return Json(new { result = downtimeDetail });
        //} 
        public async Task<IActionResult> GetDowntimeDetailByDowntimeType(string downtimetype)
        {
            var downtimeDetail = await commonService.Master_Downtime_get_bydowntimetype(downtimetype);
            return Json(new { result = downtimeDetail });
        }
        public async Task<IActionResult> GetAllDowntimeByWC([FromBody] TestViewModel model)
        {
            var token = User.GetSpecificClaim("token");

            var results = await testTechService.GetAllDowntimeByWC(model);
            return Json(new { result = results });
        }
        public async Task<IActionResult> UpdateDowntime([FromBody] UpdateDowntimeViewModel model)
        {
            var token = User.GetSpecificClaim("token");

            var result = await testTechService.UpdateDowntime(model);
            return Json(new { statusCode = result.StatusCode });
        }
        public async Task<IActionResult> UpdateStationQuantity([FromBody] UpdateStationQuantityViewModel model)
        {
            var token = User.GetSpecificClaim("token");

            var result = await testTechService.UpdateStationQuantityAsync(model, token);
            return Json(new { statusCode = result.StatusCode });
        }
        public async Task<IActionResult> GetFinalResult_partialview([FromBody] TestViewModel model)
        {
            var token = User.GetSpecificClaim("token");

            var testResult = await testTechService.Result_test_technician_calculation(model);
            var lstMonths = new List<string>() { "Sep", "Oct", "Nov", "Dec", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug" };
            ViewData["Months"] = lstMonths;
            return PartialView(testResult);
        }
        public async Task<IActionResult> UpdateTestTech([FromBody] UpdateLockedHeadcountViewModel model)
        {
            var token = User.GetSpecificClaim("token");

            var result = await testTechService.UpdateTestTechAsync(model);
            return Json(new { statusCode = result.StatusCode });
        }
        [HttpGet]
        public async Task<IActionResult> Test()
        {
            var token = User.GetSpecificClaim("token");
            string Ntlogin = User.GetSpecificClaim("Ntlogin");
            ViewData["Ntlogin"] = Ntlogin;
            var WCs = await commonService.GetWCByNTIDAsync(Ntlogin, token);
            ViewData["WCs"] = WCs;
            var FY = await commonService.Master_FiscalYear_get();
            ViewData["FY"] = FY;

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Test_Partial([FromBody] TestViewModel model)
        {
            var results = await testTechService.Equipment_GetStationList_technician(model);

            return PartialView(results);
        }

        public async Task<IActionResult> Test_Equipment_add([FromBody]  TestViewModel model)
        {
            var results = await testTechService.Test_Equipment_add(model);
            return Json(new { result = results });
        }
    }
}