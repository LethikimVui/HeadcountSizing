using System;
using System.Collections.Generic;

namespace HCSAPI.Models
{
    public partial class TestActivities
    {
        public int Id { get; set; }
        public byte? FiscalYearId { get; set; }
        public byte? CustId { get; set; }
        public int? StationOrTesterId { get; set; }
        public string DowntimeType { get; set; }
        public string DowntimeDetail { get; set; }
        public double? Duration { get; set; }
        public byte? IsTech { get; set; }
        public byte? IsOperator { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
        public byte? IsActive { get; set; }
    }
}
