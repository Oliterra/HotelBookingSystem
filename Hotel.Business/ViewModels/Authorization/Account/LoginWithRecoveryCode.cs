using System.ComponentModel.DataAnnotations;

namespace Business.ViewModels.Authorization.Account
{
    public class LoginWithRecoveryCode
    {
        [Required]
        [DataType(DataType.Text)]
        [Display (Name = "Recovery code")]
        public string RecoveryCode { get; set; }
    }
}
