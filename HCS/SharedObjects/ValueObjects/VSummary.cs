using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ValueObjects
{
    public class VSummary
    {
        public string FiscalYear { get; set; }
        public byte fiscalYearId { get; set; }
        public string Month { get; set; }
        public double? CalculatedOP { get; set; }
        public double? CalculatedTech { get; set; }
        public double? TestTech { get; set; }
        public int LockedDebugTech { get; set; }
        public int LockedDebugOperator { get; set; }
        public int LockedTestOperator { get; set; }
        public int LockedTestHeadCount { get; set; }
        public double ForecastedVolume { get; set; }

    }
}
