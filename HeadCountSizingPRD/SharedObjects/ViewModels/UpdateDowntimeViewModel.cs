using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class UpdateDowntimeViewModel
    {
        public int CustId { get; set; }
        public string DowntimeType { get; set; }
        public string DowntimeDetail { get; set; }
        public double? Duration { get; set; }
        public string StationOrTester { get; set; }
        public string UpdatedBy { get; set; }
    }
}
