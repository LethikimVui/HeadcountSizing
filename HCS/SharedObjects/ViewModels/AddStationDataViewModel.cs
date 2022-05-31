using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class AddStationDataViewModel
    {
       
        public int MonthId { get; set; }
        public int FiscalYearId { get; set; }

        public int CustId { get; set; }
        public string Station { get; set; }
        public int? Quantity { get; set; }
        public string CreatedBy { get; set; }
    }
}
