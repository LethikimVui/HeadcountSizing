using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using SharedObjects.Extensions;
using SharedObjects.ViewModels;

namespace HeadCountSizingPRD.Controllers
{
    [Authorize]

    public class DebugController : Controller
    {
        private readonly ICommonService commonService;
        private readonly IDebugService debugService;

        public DebugController(ICommonService commonService, IDebugService debugService)
        {
            this.commonService = commonService;
            this.debugService = debugService;
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
        public async Task<IActionResult> GetRawDataAsync_partialview(int wcId)
        {
            var token = User.GetSpecificClaim("token");

            var rawdata = await debugService.GetRawDataAsync(token, wcId);
            return PartialView(rawdata);
        }
        [HttpGet]
        public async Task<IActionResult> MonthlyDataEntrance()
        {
            var token = User.GetSpecificClaim("token");
            string Ntlogin = User.GetSpecificClaim("Ntlogin");
            ViewData["Ntlogin"] = Ntlogin;
            var WCs = await commonService.GetWCByNTIDAsync(Ntlogin, token);
            ViewData["WCs"] = WCs;
            var Shifts = await commonService.GetShift();
            ViewData["Shifts"] = Shifts;

            return View();
        }

        public async Task<IActionResult> AddRawData(AddRawDataViewModel model)
        {
            if (ModelState.IsValid)
            {
                var token = User.GetSpecificClaim("token");
                var result = await debugService.AddRawDataAsync(model, token);
                if (result.StatusCode == 200)
                {
                    return RedirectToAction("search", "debug");
                }
                else
                {
                    foreach (var item in result.Notifications)
                    {
                        ModelState.AddModelError("", item);
                    }
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }
        public async Task<IActionResult> UpdateRawData([FromBody] AddRawDataViewModel model)
        {
            var token = User.GetSpecificClaim("token");
            var result = await debugService.UpdateRawDataAsync(model, token);
            return Json(new { statusCode = result.StatusCode });
        }

        public async Task<IActionResult> GetDebugData_partialview(int wcId)
        {
            var token = User.GetSpecificClaim("token");
            var debugdata = await debugService.GetDebugDataAsync(token, wcId);

            return PartialView(debugdata);
        }
        public async Task<IActionResult> UpdateDebugData([FromBody] DebugDataViewModel model)
        {
            var token = User.GetSpecificClaim("token");
            var result = await debugService.UpdateDebugDataAsync(model, token);
            return Json(new { statusCode = result.StatusCode });
        }
        public async Task<IActionResult> AddDebugDataBody([FromBody] DebugDataViewModel model)
        {
            var token = User.GetSpecificClaim("token");
            var result = await debugService.AddDebugDataAsync(model, token);
            return Json(new { statusCode = result.StatusCode });
        }
        public async Task<IActionResult> DeleteDebugData([FromBody] DebugDataViewModel model)
        {
            var token = User.GetSpecificClaim("token");
            var result = await debugService.DeleteAsync(model, token);
            return Json(new { statusCode = result.StatusCode });
        }
        public async Task<IActionResult> GetDebugResult_partialview(int wcId)
        {
            var token = User.GetSpecificClaim("token");
            var debugresult = await debugService.GetDebugResultAsync(token, wcId);
            return PartialView(debugresult);
        }
        public async Task<IActionResult> UpdateDebugTech([FromBody] UpdateHeadcountViewModel model)
        {
            var token = User.GetSpecificClaim("token");
            var result = await debugService.UpdateDebugTechAsync(model, token);
            return Json(new { statusCode = result.StatusCode });
        }

    }
}