using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ValueObjects
{
    public class VDebugData
    {
        public int Id { get; set; }
        public string Wc { get; set; }
        public string Station { get; set; }
        public double? DebugHitrateYield { get; set; }
        public double? NormalRate { get; set; }
        public double? HardcoreRate { get; set; }
        public double? DebugTimeForNormalBoard { get; set; }
        public double? DebugTimeForHardcoreBoard { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateBy { get; set; }
        public byte? IsActive { get; set; }
        public double? FinalYield { get; set; }
        public double? DebugRetestPassYield { get; set; }
        public double? RMA { get; set; }
    }
}
