using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class DebugDataViewModel
    {
        public int Id { get; set; }
        public byte CustId { get; set; }
        public string Station { get; set; }
        public double? HardcoreRate { get; set; }
        public double? TimeForHardcoreBoard { get; set; }
        public double? TimeForNormalBoard { get; set; }
        public double? FinalYield { get; set; }
        public double? HitrateYield { get; set; }
        public double? RetestPassYield { get; set; }
        public double? RMA { get; set; }
        public string UpdatedBy { get; set; }
    }
}
