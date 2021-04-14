using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObjects.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "NTID is required")]       
        public string NTID { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
