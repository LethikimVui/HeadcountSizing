using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class UpdateDebugRawDataByWCandMonthViewModel
    {
        [Required(ErrorMessage = "Please select WC")]
        [Display(Name = "Workcell")]
        public string Wc { get; set; }
        [Required(ErrorMessage = "Please select Month")]
        [Display(Name = "Month")]
        public string Month { get; set; }
        [Required(ErrorMessage = "Please input WorkingDayPerMonth")]
        [Display(Name = "Working Day Per Month")]
        public int? WorkingDayPerMonth { get; set; }
        [Required(ErrorMessage = "Please WorkingHourPerShift")]
        [Display(Name = "Working Hour Per Shift")]
        public double? WorkingHourPerShift { get; set; }
        [Required(ErrorMessage = "Please ShifPatten")]
        [Display(Name = "Shift Pattern")]
        public string ShifPatten { get; set; }
        [Required(ErrorMessage = "Please WorkEfficiency")]
        [Display(Name = "Work Efficiency")]
        public double? WorkEfficiency { get; set; }
        [Required(ErrorMessage = "Please TotalLoadingForDebug")]
        [Display(Name = "Total Loading For Debug")]
        public int? TotalLoadingForDebug { get; set; }
        [Required(ErrorMessage = "Please UpdateBy")]
        [Display(Name = "Update By")]
        public string UpdateBy { get; set; }
        [Required(ErrorMessage = "Please CoverRate")]
        [Display(Name = "CoverRate")]
        public int? CoverRate { get; set; }

    }
}
