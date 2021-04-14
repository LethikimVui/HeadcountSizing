using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class AddStationDataViewModel
    {
        public string FiscalYear { get; set; }

        public string Month { get; set; }
        public string WC { get; set; }
        public string Station { get; set; }
        public int? Quantity { get; set; }
        public int MonthID { get; set; }
        public string CreatedBy { get; set; }
    }
}
