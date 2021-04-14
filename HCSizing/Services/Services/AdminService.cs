using Newtonsoft.Json;
using Services.Interfaces;
using SharedObjects.Common;
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
      
        public async Task<VAccessUserRole> User_Role_SelectAsync(string ntid)
        {
            VAccessUserRole userRole = new VAccessUserRole();

            using (var response = await httpClient.GetAsync("api/admin/User_Role_Select/" + ntid))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                userRole = JsonConvert.DeserializeObject<VAccessUserRole>(apiResponse);
            }
            return userRole;
        }

        public async Task<List<VAccessUserRole>> User_Role_Select_AllAsync()
        {
            List<VAccessUserRole> userRoles = new List<VAccessUserRole>();

            using (var response = await httpClient.GetAsync("api/admin/User_Role_Select_All"))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                userRoles = JsonConvert.DeserializeObject<List<VAccessUserRole>>(apiResponse);
            }
            return userRoles;
        }
    }
}
