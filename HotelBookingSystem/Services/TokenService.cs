using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.ModelBinding;
using Business.ViewModels;
using Business.ViewModels.Authorization;
using Business.ViewModels.Authorization.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using WebAPI.Interfaces;
using TokenOptions = Business.ViewModels.Authorization.TokenOptions;

namespace WebAPI.Services
{
    public class TokenService : ITokenService
    {

        private readonly TokenOptions _tokenOptions;

        public TokenService(IOptions<TokenOptions> tokens)
        {
            _tokenOptions = tokens.Value;
        } 
        private string GenerateJWT()
        {
            // Create token key
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenOptions.Key));
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            // Set token expiration
            DateTime startTime = DateTime.UtcNow;
            DateTime expiryTime = startTime.AddMinutes(15);

            // Generate the token
            JwtSecurityToken token =
                new JwtSecurityToken(
                    "Microsoft.Security.Bearer",
                    "Microsoft.Security.Bearer",
                    null,
                    notBefore: startTime,
                    expires: expiryTime,
                    signingCredentials: credentials);

            string result = new JwtSecurityTokenHandler().WriteToken(token);

            return result;
        }

        public TokenOptions GenerateToken()
        {
            TokenOptions token = new TokenOptions();
            token.Token = GenerateJWT();
            return token;
        }
    }
}
