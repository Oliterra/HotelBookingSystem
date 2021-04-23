using System.ComponentModel.DataAnnotations;

namespace Business.ViewModels.Authorization.Account
{
    public class ForgotPassword
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
