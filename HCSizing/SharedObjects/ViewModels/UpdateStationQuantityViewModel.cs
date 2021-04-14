using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class UpdateStationQuantityViewModel
    {
        public string FiscalYear { get; set; }

        public string Wc { get; set; }
        public string Month { get; set; }
        public string StationOrTester { get; set; }
  
        public int Quantity { get; set; }
        public string UpdatedBy { get; set; }

    }
}
