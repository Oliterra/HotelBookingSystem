using System.ComponentModel.DataAnnotations;

namespace Business.Models.Authorization.AccountViewModel
{
    public class ExternalLogin
    {
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
