using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models.Authorization.Manage
{
    public class TwoFactorAuthentication
    {
        public bool HasAuthenticator { get; set; }

        public bool RecoveryCodesLeft { get; set; }

        public bool Is2faEnabled { get; set; }
    }
}
