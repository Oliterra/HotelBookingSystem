using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;

namespace Business.Models.Authorization.Manage
{
    public class ExternalLogins
    {
        public IList<UserLoginInfo> CurrentLogin { get; set; }

        public IList<AuthenticationScheme> OtherLogins { get; set; }

        public bool ShowRemoteButton { get; set; }

        public string StatusMessage { get; set; }
    }
}
