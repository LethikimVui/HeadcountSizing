using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ValueObjects
{
    public class VDebugResult
    {
        public string FiscalYear { get; set; }
        public string Month { get; set; }
        public string CalculatedOP { get; set; }
        public string CalculatedTech { get; set; }
        public double? RoundUpOP { get; set; }
        public double? RoundUpTech { get; set; }
        public int? LockedTech { get; set; }
        public int? LockedOperator { get; set; }
    }
}
