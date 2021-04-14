using System;
using System.Collections.Generic;

namespace HCSizingAPI.Models
{
    public partial class Activities
    {
        public int Id { get; set; }
        public string DowntimeType { get; set; }
        public string DowntimeDetail { get; set; }
        public double? Duration { get; set; }
        public byte? IsActive { get; set; }
        public string StationOrTester { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Wc { get; set; }
    }
}
