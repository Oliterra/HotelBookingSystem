using Business.ViewModels.Authorization.Account;
using Business.ViewModels.Authorization.ManageViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;
using TokenOptions = Business.ViewModels.Authorization.TokenOptions;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly TokenOptions _tokenOptions;

        public TokenController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
            IOptions<TokenOptions> tokens)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenOptions = tokens.Value;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Generate([FromBody] Login model)
        {
            if (ModelState.IsValid) return BadRequest("Token is not find");

            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null) return BadRequest("Couldn't create the token");

            var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);

            if (!result.Succeeded) return BadRequest("Couldn't create the token");

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenOptions.Key));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _tokenOptions.Issuer,
                audience: _tokenOptions.Issuer,
                claims: User.Claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);

            return Ok(new JwtSecurityTokenHandler().WriteToken(token));
        }      
    }
}
