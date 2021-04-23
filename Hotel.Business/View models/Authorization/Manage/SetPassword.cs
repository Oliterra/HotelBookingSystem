using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.ViewModels.Authorization.Manage
{
    public class SetPassword
    {
        [Required]
        [StringLength( 100, ErrorMessage = "The {0} must be at least {2} and at max {1} character long", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display (Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password doesn't match")]
        public string ConfirmPassword { get; set; }

        public string StatusMessage { get; set; }
    }
}
