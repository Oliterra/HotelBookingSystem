using System.ComponentModel.DataAnnotations;

namespace Business.ViewModels.Authorization.Account
{
    public class Register
    {
        [Required]
        [EmailAddress]
        [Display (Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} ana at max {1} character long", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display (Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display (Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirm password don't match")]
        public string ConfirmPassword { get; set; }
    }
}
