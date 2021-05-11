using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ValueObjects
{
    public class VUsers
    {
        public int UserRoleId { get; set; }
        public string Ntlogin { get; set; }
        public string UserName { get; set; }
        public byte PlantId { get; set; }
        public byte CustId { get; set; }
        public string CustName { get; set; }
        public Byte RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
