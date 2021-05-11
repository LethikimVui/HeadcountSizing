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
    public class TestOperatorController : Controller
    {
        private readonly ICommonService commonService;
        private readonly ITestOperatorService testOperatorService;

        public TestOperatorController(ICommonService commonService, ITestOperatorService testOperatorService)
        {
            this.commonService = commonService;
            this.testOperatorService = testOperatorService;
        }
        public async Task<IActionResult> Search()
        {
            var token = User.GetSpecificClaim("token");

            //string id = User.GetSpecificClaim("CustId");
            //int CustId = Int16.Parse(id);
            //var WCs = await commonService.GetWCAsync(CustId, token);

            string Ntlogin = User.GetSpecificClaim("Ntlogin");
            var WCs = await commonService.GetWCByNTIDAsync(Ntlogin, token);


            ViewData["WCs"] = WCs;
            return View();
        }
        public async Task<IActionResult> DataTable(int wcId)
        {
            var token = User.GetSpecificClaim("token");

            var result = await testOperatorService.GetallStationAsync(wcId, token);
            var downtimeDetail = await testOperatorService.GetDowntimeTypeAndDowntimeDetailAsync(wcId);
            ViewData["downtimeDetail"] = downtimeDetail;
            return PartialView(result);
        }
        public async Task<IActionResult> GetallStation(int wcId)
        {
            var token = User.GetSpecificClaim("token");

            var stations = await testOperatorService.GetallStationAsync(wcId, token);
            return Json(new { result = stations });
        }
        public async Task<IActionResult> GetEquipmentQuantity([FromBody] GetEquipmentQuantity model)
        {
            var token = User.GetSpecificClaim("token");

            var quantity = await testOperatorService.GetEquipmentQuantityAsync(model, token);
            return Json(new { result = quantity });
        }
        public async Task<IActionResult> AddStationData([FromBody] AddStationDataViewModel model)
        {
            var token = User.GetSpecificClaim("token");

            var result = await testOperatorService.AddStationDataAsync(model, token);
            return Json(new { statusCode = result.StatusCode });
        }
        public async Task<IActionResult> GetDowntimeDetailByDowntimeType([FromBody] GetDowntimeViewModel model)
        {
            var downtimeDetail = await commonService.GetDowntimeDetailByDowntimeTypeOperatorAsync(model);
            return Json(new { result = downtimeDetail });
        }
        public async Task<IActionResult> GetAllDowntimeByWC(int wcId)
        {
            var token = User.GetSpecificClaim("token");

            var results = await testOperatorService.GetAllDowntimeByWCAsync(wcId, token);
            return Json(new { result = results });
        }
        public async Task<IActionResult> UpdateDowntime([FromBody] UpdateDowntimeViewModel model)
        {
            var token = User.GetSpecificClaim("token");

            var result = await testOperatorService.UpdateDowntimeAsync(model, token);
            return Json(new { statusCode = result.StatusCode });
        }
        public async Task<IActionResult> UpdateStationQuantity([FromBody] UpdateStationQuantityViewModel model)
        {
            var token = User.GetSpecificClaim("token");

            var result = await testOperatorService.UpdateStationQuantityAsync(model, token);
            return Json(new { statusCode = result.StatusCode });
        }
        public async Task<IActionResult> GetFinalResult_partialview(int wcId)
        {
            var token = User.GetSpecificClaim("token");

            var testResult = await testOperatorService.GetFinalResultAsync(wcId, token);
            var lstMonths = new List<string>() { "Sep", "Oct", "Nov", "Dec", "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug" };
            ViewData["Months"] = lstMonths;
            return PartialView(testResult);
        }
        public async Task<IActionResult> UpdateTestTech([FromBody] UpdateLockedHeadcountViewModel model)
        {
            var token = User.GetSpecificClaim("token");

            var result = await testOperatorService.UpdateTestTechAsync(model, token);
            return Json(new { statusCode = result.StatusCode });
        }
    }
}