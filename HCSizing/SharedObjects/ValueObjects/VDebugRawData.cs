using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ValueObjects
{
    public class VDebugRawData
    {
        public int Id { get; set; }
        public string Wc { get; set; }
        public int? WorkingDayPerMonth { get; set; }
        public double? WorkingHourPerShift { get; set; }
        public string ShiftPatten { get; set; }
        public double? WorkEfficiency { get; set; }
        public int? ForecastedVolume { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public byte? IsActive { get; set; }
        public string Month { get; set; }

        public byte MonthId { get; set; }
        public int? CoverRate { get; set; }
        public string FiscalYear { get; set; }
    }
}
