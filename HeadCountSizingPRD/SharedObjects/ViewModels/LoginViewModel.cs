using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SharedObjects.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "NTLogin is required")]
        public string NTLogin { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}

