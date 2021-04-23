using System.ComponentModel.DataAnnotations;

namespace Business.ViewModels.Authorization.AccountViewModel
{
    public class ForgotPassword
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
