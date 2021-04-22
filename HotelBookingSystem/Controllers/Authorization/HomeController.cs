using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Business.Models.Authorization;
using Business.Models.Authorization.ManageViewModel;
using Microsoft.AspNetCore.Identity;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            //return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application page";
            // return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page";
            // return View();
        }

        public async Task<IActionResult> AddUserClaim()
        {
            var user = await _userManager.GetUserAsync(User);
            var claim = new Claim("User");
            var addClaimResult = await _userManager.AddClaimsAsync(user, claim);
            //return View(addClaimResult);
        }

        public IActionResult Error()
        {
            //return View (new Error { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
