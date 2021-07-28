using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModel
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Name must be between 5 and 15 characters")]
        public string Username { get; set; }

        [Compare("VerifyPassword", ErrorMessage ="Passwords must match.")]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password is too long!")]
        public string Password { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }
               
        public string VerifyPassword { get; set; }
    }
}
