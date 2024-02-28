using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Identity.ViewModels
{
    public class SignUpVM
    {
        
        [DisplayName("Username")]
        public string UserName { get; set; } = null!;
        [DisplayName("Email")]
        public string Email { get; set; } = null!;
        [DisplayName("Password")]
        public string Password { get; set; } 
        [DisplayName("ConfirmPassword")]
        public string ConfirmPassword { get; set; } 
    }
}
