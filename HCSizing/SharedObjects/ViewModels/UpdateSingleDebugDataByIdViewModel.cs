using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class UpdateSingleDebugDataByIdViewModel
    {
        public int Id { get; set; }
        public string Station { get; set; }
        public double? DebugHitrateYield { get; set; }
        public double? HardcoreRate { get; set; }
        public double? DebugTimeForNormalBoard { get; set; }
        public double? DebugTimeForHardcoreBoard { get; set; }
        public string UpdateBy { get; set; }
        public double? FinalYield { get; set; }
        public double? DebugRetestPassYield { get; set; }
        public double? RMA { get; set; }

    }
}
