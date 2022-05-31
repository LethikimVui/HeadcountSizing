using Newtonsoft.Json;
using Services.Interfaces;
using SharedObjects.Commons;
using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class AdminService : BaseService, IAdminService
    {
        public async Task<ResponseResult> Access_UserRole_addAsync(AddUserRoleViewModel model, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            ResponseResult responseResult = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/admin/AddUserRole", content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<ResponseResult> Access_UserRole_DeleteAsync(int roleId, string updatedBy, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            ResponseResult responseResult = new ResponseResult();
            //StringContent content = new StringContent(JsonConvert.SerializeObject(roleId), Encoding.UTF8, "application/json");
            using (var response = await httpClient.GetAsync("api/admin/DeleteUserRole/"+roleId + "/" +updatedBy))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                responseResult = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return responseResult;
        }

        public async Task<List<VRole>> Access_Role_selectAsync()
        {

            List<VRole> roles = new List<VRole>();

            using (var response = await httpClient.GetAsync("api/Admin/getrole"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                roles = JsonConvert.DeserializeObject<List<VRole>>(apiResponse);
            }
            return roles;
        }

        public async Task<List<VAccessUserRole>> Access_UserRole_get(string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            List<VAccessUserRole> userRoles = new List<VAccessUserRole>();

            using (var response = await httpClient.GetAsync("api/Admin/getall"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                userRoles = JsonConvert.DeserializeObject<List<VAccessUserRole>>(apiResponse);
            }
            return userRoles;
        }

        public async Task<VAccessUserRole> Access_UserRole_getbyNTloginAsync(string Ntlogin, string token)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

            VAccessUserRole userRole = new VAccessUserRole();

            using (var response = await httpClient.GetAsync("api/Admin/getbyNTlogin/" + Ntlogin))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                userRole = JsonConvert.DeserializeObject<VAccessUserRole>(apiResponse);
            }
            return userRole;
        }
    }
}
