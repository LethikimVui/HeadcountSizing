using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class GetDowntimeViewModel
    {
        public string Wc { get; set; }
        public string DowntimeType { get; set; }
        public string DowntimeDetail { get; set; }
   
    }
}
