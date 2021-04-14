using SharedObjects.Common;
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
        Task<VAccessUserRole> User_Role_SelectAsync(string ntid);
      
        Task<List<VAccessUserRole>> User_Role_Select_AllAsync();
       
    }
}
