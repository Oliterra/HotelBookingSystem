using System.ComponentModel.DataAnnotations;

namespace Business.Models.Authorization.AccountViewModel
{
    public class ForgotPassword
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
