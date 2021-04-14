using System;
using System.Collections.Generic;

namespace HCSizingAPI.Models
{
    public partial class AccessUserRole
    {
        public int UserRoleId { get; set; }
        public string Ntlogin { get; set; }
        public int? RoleId { get; set; }
        public int? PlantId { get; set; }
        public int? CustId { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
