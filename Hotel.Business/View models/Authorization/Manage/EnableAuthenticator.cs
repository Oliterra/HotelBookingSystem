using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.ViewModels.Authorization.Manage
{
    public class EnableAuthenticator
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} character string")]
        [DataType(DataType.Text)]
        [Display(Name = "Verification code")]
        public string Code { get; set; }

        [ReadOnly(true)] public string SharedKey { get; set; }

        public string AuthenticationUri { get; set; }
    }
}
