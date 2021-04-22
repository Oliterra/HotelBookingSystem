using System.ComponentModel.DataAnnotations;

namespace Business.Models.Authorization.Account
{
    public class Login
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display (Name = "remember me?")]
        public bool RememberMe { get; set; }
    }
}
