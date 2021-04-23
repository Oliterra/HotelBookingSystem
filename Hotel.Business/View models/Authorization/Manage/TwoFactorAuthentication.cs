using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ViewModels.Authorization.Manage
{
    public class TwoFactorAuthentication
    {
        public bool HasAuthenticator { get; set; }

        public int RecoveryCodesLeft { get; set; }

        public bool Is2faEnabled { get; set; }
    }
}
