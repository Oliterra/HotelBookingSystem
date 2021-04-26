using System.ComponentModel.DataAnnotations;
using System;

namespace Business.ViewModels.Authorization.Account
{
    public class ForgotPassword
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
