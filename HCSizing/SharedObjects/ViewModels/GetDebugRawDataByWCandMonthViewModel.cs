using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class GetDebugRawDataByWCandMonthViewModel
    {
        [Required(ErrorMessage = "Please select Month")]
        [Display(Name = "Month")]
        public string Month { get; set; }
        [Required(ErrorMessage = "Please select WC")]
        [Display(Name = "Workcell")]
        public string Wc { get; set; }
    }
}
