using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class AddUserRoleViewModel
    {
        public string Ntlogin { get; set; }
        public string UserName { get; set; }
        public byte RoleId { get; set; }
        public byte PlantId { get; set; }
        public byte CustId { get; set; }
        public string CreatedBy { get; set; }
    }
}
