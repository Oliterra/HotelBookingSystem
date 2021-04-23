using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ViewModels.Authorization.Manage
{
    public class RemoteLogin
    {
        public string LoginProvider { get; set; }

        public string ProviderKey { get; set; }
    }
}
