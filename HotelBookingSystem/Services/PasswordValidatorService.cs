using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Business.ViewModels.Authorization;
using Microsoft.AspNetCore.Identity;

namespace WebAPI.Services
{
    public class PasswordValidatorService : IPasswordValidator<ApplicationUser>
    {
        public int RequiredLength { get; set; } //min Lenght

        public PasswordValidatorService(int length)
        {
            RequiredLength = length;
        }
        public Task<IdentityResult> ValidateAsync(UserManager<ApplicationUser> manager, ApplicationUser user, string password)
        {
            var errors = new List<IdentityError>();

            if (string.IsNullOrEmpty(password) || password.Length < RequiredLength)
            {
                errors.Add(new IdentityError
                {
                    Description = $"Minimum password length is {RequiredLength}"
                });
            }
            var pattern = "^[a-zA-Z0-9]+$";

            if (!Regex.IsMatch(password, pattern))
            {
                errors.Add(new IdentityError
                {
                    Description = "Password must be contained numbers and letters"
                });
            }
            return Task.FromResult(errors.Count == 0 ? IdentityResult.Success : IdentityResult.Failed(errors.ToArray()));
        }
    }
}
