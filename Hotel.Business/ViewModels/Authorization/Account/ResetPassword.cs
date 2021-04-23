using System.ComponentModel.DataAnnotations;

namespace Business.ViewModels.Authorization.Account
{
    public class ResetPassword
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} character long")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display (Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The new password and confirmation password doesn't match")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }
}
