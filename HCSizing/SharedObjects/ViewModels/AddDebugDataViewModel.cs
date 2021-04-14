using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class AddDebugDataViewModel
    {
        [Required(ErrorMessage = "Please select Wc")]
        [Display(Name = "Workcell")]
        public string Wc { get; set; }
        [Required(ErrorMessage = "Please select Station")]
        [Display(Name = "Station")]
        public string Station { get; set; }
        [Required(ErrorMessage = "Please input DebugHitrateYield")]
        [Range(0, 100)]
        [Display(Name = "DebugHitrateYield")]
        public double? DebugHitrateYield { get; set; }
        [Required(ErrorMessage = "Please input NormalRate")]
        [Range(0, 100)]
        [Display(Name = "Hard Rate")]
        public double? HardcoreRate { get; set; }
        [Required(ErrorMessage = "Please select DebugTimeForNormalBoard")]
        [Display(Name = "DebugTimeForNormalBoard")]
        public double? DebugTimeForNormalBoard { get; set; }
        [Required(ErrorMessage = "Please select DebugTimeForHardcoreBoard")]
        [Display(Name = "DebugTimeForHardcoreBoard")]
        public double? DebugTimeForHardcoreBoard { get; set; }        
        [Required(ErrorMessage = "Please select UpdateBy")]
        [Display(Name = "Update By")]
        public string UpdateBy { get; set; }       
        [Required(ErrorMessage = "Please select FinalYield")]
        [Range(0, 100)]
        [Display(Name = "Final Yield")]
        public double? FinalYield { get; set; }
        [Required(ErrorMessage = "Please input DebugRetestPassYield")]
        [Range(0, 100)]
        [Display(Name = "Debug Retest Pass Yield")]

        public double? DebugRetestPassYield { get; set; }
        [Required(ErrorMessage = "Please input RMA board (Qty)")]
        [Display(Name = "RMA")]
        public double? RMA { get; set; }
    }
}
