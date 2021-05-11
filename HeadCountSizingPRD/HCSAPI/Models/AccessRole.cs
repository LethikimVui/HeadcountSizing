using System;
using System.Collections.Generic;

namespace HCSAPI.Models
{
    public partial class AccessRole
    {
        public byte RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescr { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
        public byte? IsActive { get; set; }
    }
}
