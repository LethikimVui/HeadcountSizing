using System;
using System.Collections.Generic;

namespace HCSizingAPI.Models
{
    public partial class DebugRawData
    {
        public int Id { get; set; }
        public string Wc { get; set; }
        public int? WorkingDayPerMonth { get; set; }
        public double? WorkingHourPerShift { get; set; }
        public string ShifPatten { get; set; }
        public double? WorkEfficiency { get; set; }
        public int? TotalLoadingForDebug { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public byte? IsActive { get; set; }
        public string Month { get; set; }
        public int? CoverRate { get; set; }
    }
}
