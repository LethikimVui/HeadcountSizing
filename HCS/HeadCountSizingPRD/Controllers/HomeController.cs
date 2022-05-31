using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HeadCountSizingPRD.Models;
using Services.Interfaces;

using SharedObjects.Extensions;
using SharedObjects.ViewModels;

namespace HeadCountSizingPRD.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDebugService debugService;
        private readonly ICommonService commonService;

        public HomeController(IDebugService debugService, ICommonService commonService)
        {
            this.debugService = debugService;
            this.commonService = commonService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public async Task<IActionResult> Summary()
        {
            var token = User.GetSpecificClaim("token");

            string Ntlogin = User.GetSpecificClaim("Ntlogin");
            var WCs = await commonService.GetWCByNTIDAsync(Ntlogin, token);
            var FY = await commonService.Master_FiscalYear_get();


            ViewData["WCs"] = WCs;
            ViewData["FY"] = FY;
            return View();
        }
        public async Task<IActionResult> Headcount()
        {
            var token = User.GetSpecificClaim("token");

            string Ntlogin = User.GetSpecificClaim("Ntlogin");
            var WCs = await commonService.GetWCByNTIDAsync(Ntlogin, token);
            var FY = await commonService.Master_FiscalYear_get();


            ViewData["WCs"] = WCs;
            ViewData["FY"] = FY;
            return View();
        }
        public async Task<IActionResult> Summary_part([FromBody] SummaryViewModel model)
        {
            var results = await commonService.Summary(model);
            return PartialView(results);
        }
        public async Task<IActionResult> Headcount_part([FromBody] SummaryViewModel model)
        {
            var results = await commonService.Summary(model);
            return PartialView(results);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
