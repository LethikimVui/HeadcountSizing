using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class AddDebugRawDataViewModel
    {
        
        [Required(ErrorMessage = "Please select Workcell")]
        [Display(Name = "Workcell")]
        public string Wc { get; set; }
        public int MonthID { get; set; }
        [Required(ErrorMessage = "Please input working day per month")]
        [Display(Name = "Working Day (days)")]
        [Range(0, 26)]
        public int? WorkingDayPerMonth { get; set; }
        [Required(ErrorMessage = "Please input working hour per shift")]
        [Display(Name = "Working Hour Per Shift (hours)")]
        [Range(0, 24)]
        public double? WorkingHourPerShift { get; set; }
        [Required(ErrorMessage = "Please select shift pattern")]
        [Display(Name = "Shift Pattern")]
        public string ShiftPatten { get; set; }
        [Range(0, 100)]
        [Required(ErrorMessage = "Please input Working Efficiency")]
        [Display(Name = "Working Efficiency (%)")]
        public double? WorkEfficiency { get; set; }
        [Required(ErrorMessage = "Please input Total Loading For Debug")]
        [Display(Name = "Forecasted volume (Qty)")]
        public int? ForecastedVolume { get; set; }
        [Required(ErrorMessage = "Please input Update By")]
        [Display(Name = "Update By")]
        public string UpdateBy { get; set; }
        [Range(0, 100)]
        [Required(ErrorMessage = "Please input technician Coverage")]
        [Display(Name = "Coverage (%)")]
        public int? Coverage { get; set; }
    }
}
