using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ValueObjects
{
    public class VRawData
    {
        public string FiscalYear { get; set; }
        public string Month { get; set; }
        public byte MonthId { get; set; }
        public int? WorkingDayPerMonth { get; set; }
        public double? WorkingHourPerShift { get; set; }
        public string ShiftCode { get; set; }
        public byte ShiftId { get; set; }
        public double? WorkingEfficiency { get; set; }
        public double? ForecastedVolume { get; set; }
        public double? Coverage { get; set; }
    }
}
