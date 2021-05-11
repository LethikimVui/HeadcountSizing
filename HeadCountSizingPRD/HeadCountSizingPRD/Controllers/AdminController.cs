using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SharedObjects.Extensions;
using System.DirectoryServices;
using Services.Interfaces;
using SharedObjects.ViewModels;

namespace HeadCountSizingPRD.Controllers
{
    public class AdminController : Controller
    {
        private readonly ICommonService commonService;
        private readonly IAdminService adminService;

        public AdminController(ICommonService commonService, IAdminService adminService)
        {
            this.commonService = commonService;
            this.adminService = adminService;
        }
        public string GetProperty(string ntid, string info)
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
                return string.Empty;
            }
        }    
        public async Task<IActionResult> AllUser()
        {
            var token = User.GetSpecificClaim("token");

            var userRoles = await adminService.Access_UserRole_get(token);
            var roles = await adminService.Access_Role_selectAsync();

            string id = User.GetSpecificClaim("CustId");
            int CustId = Int16.Parse(id);
            var WCs = await commonService.GetWCAsync(CustId, token);

            ViewData["roles"] = roles;
            ViewData["WCs"] = WCs;

            return View(userRoles);
        }
        public async Task<IActionResult> GetUserRoleByNTlogin(string Ntlogin)
        {
            var token = User.GetSpecificClaim("token");
            var results = await adminService.Access_UserRole_getbyNTloginAsync(Ntlogin, token);
            return Json(new { result = results });
        }
        public async Task<IActionResult> AddUserRole([FromBody] AddUserRoleViewModel model)
        {
            var token = User.GetSpecificClaim("token");
            var result = await adminService.Access_UserRole_addAsync(model, token);
            return Json(new { statusCode = result.StatusCode });
        }
        public async Task<IActionResult> DeleteUserRole(int roleId, string updatedBy)
        {
            var token = User.GetSpecificClaim("token");
            var result = await adminService.Access_UserRole_DeleteAsync(roleId, updatedBy, token);
            return Json(new { statusCode = result.StatusCode });
        }


    }
}