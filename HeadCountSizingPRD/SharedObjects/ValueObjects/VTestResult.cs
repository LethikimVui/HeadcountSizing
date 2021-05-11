using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ValueObjects
{
    public class VTestResult
    {
        public string FiscalYear { get; set; }
        public byte monthId { get; set; }
        public string Month { get; set; }
        public string Calculated { get; set; }
        public double? RoundUp { get; set; }
        public int? LockedHeadCount { get; set; }

    }
}
