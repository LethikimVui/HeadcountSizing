using System;
using System.Collections.Generic;

namespace HCSAPI.Models
{
    public partial class AccessUserRole
    {
        public int UserRoleId { get; set; }
        public string Ntlogin { get; set; }
        public string UserName { get; set; }
        public byte? RoleId { get; set; }
        public byte? PlantId { get; set; }
        public byte? CustId { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
        public byte? IsActive { get; set; }
    }
}
