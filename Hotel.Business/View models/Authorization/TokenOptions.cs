using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Business.ViewModels.Authorization
{
    public class TokenOptions
    {
        public string Issuer { get; set; }
        public string Key { get; set; }
    }
}
