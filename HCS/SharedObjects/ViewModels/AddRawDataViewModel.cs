using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class AddRawDataViewModel
    {
        [Required(ErrorMessage = "Data is required")]
        [Display(Name = "Workcell")]
        public int CustId { get; set; }
        [Required(ErrorMessage = "Data is required")]
        [Display(Name = "MonthId")]
        public byte MonthId { get; set; }
        [Required(ErrorMessage = "Data is required")]
        [Display(Name = "Shift")]
        public byte ShiftId { get; set; }
        [Required(ErrorMessage = "Data is required")]
        [Display(Name = "Working Efficiency")]
        public double WorkingEfficiency { get; set; }
        [Required(ErrorMessage = "Data is required")]
        [Display(Name = "Forecasted Volume")]
        public double ForecastedVolume { get; set; }
        [Required(ErrorMessage = "Data is required")]
        [Display(Name = "Working Day Per Month")]
        public int WorkingDayPerMonth { get; set; }
        [Required(ErrorMessage = "Data is required")]
        [Display(Name = "Working Hour Per Shift")]
        public double WorkingHourPerShift { get; set; }
        [Required(ErrorMessage = "Data is required")]
        [Display(Name = "Coverage")]
        public double Coverage { get; set; }
        [Display(Name = "Updated By")]
        public string UpdatedBy { get; set; }
        public int FiscalYearId { get; set; }
    }
}
