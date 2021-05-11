using SharedObjects.Commons;
using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IAdminService
    {
        Task<List<VAccessUserRole>> Access_UserRole_get(string token);
        Task<VAccessUserRole> Access_UserRole_getbyNTloginAsync(string Ntlogin , string token);
        Task<List<VRole>> Access_Role_selectAsync();
        Task<ResponseResult> Access_UserRole_addAsync(AddUserRoleViewModel model, string token);
        Task<ResponseResult> Access_UserRole_DeleteAsync(int roleId, string updatedBy, string token);

    }
}
