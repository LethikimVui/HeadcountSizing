using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class UpdateDowntimeViewModel
    {
        public string Wc { get; set; }
        public string DowntimeType { get; set; }
        public string DowntimeDetail { get; set; }
        public double? Duration { get; set; }       
        public string StationOrTester { get; set; }
        public string CreatedBy { get; set; }        
        public string UpdatedBy { get; set; }       
    }
}
