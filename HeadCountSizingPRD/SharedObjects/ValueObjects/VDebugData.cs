using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ValueObjects
{
    public class VDebugData
    {
        public byte Id { get; set; }
        public string Station { get; set; }
        public double? HardcoreRate { get; set; }
        public double? DebugTimeForHardcoreBoard { get; set; }
        public double? DebugTimeForNormalBoard { get; set; }
        public double? FinalYield { get; set; }
        public double? DebugHitrateYield { get; set; }
        public double? DebugRetestPassYield { get; set; }
        public double? Rma { get; set; }
    }
}
