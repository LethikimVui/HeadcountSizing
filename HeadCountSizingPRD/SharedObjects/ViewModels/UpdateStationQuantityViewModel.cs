using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class UpdateStationQuantityViewModel
    {
        public int CustId { get; set; }
        public int MonthId { get; set; }
        public string StationOrTester { get; set; }
        public int Quantity { get; set; }
        public string UpdatedBy { get; set; }
    }
}
