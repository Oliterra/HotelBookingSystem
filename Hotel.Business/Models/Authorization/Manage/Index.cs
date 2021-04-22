using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Business.Models.Authorization.Manage
{
    public class Index
    {
        public string UserName { get; set; }
        
        public string IsEmailConfirmed { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }
    }
}
