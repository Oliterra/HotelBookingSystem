using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using WebAPI.Interfaces;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "SuperAdministratorRole")]
    public class SuperAdminController : ControllerBase
    {
        private readonly ISuperAdminService _superAdminService;

        public SuperAdminController(ISuperAdminService superAdminService)
        {
            _superAdminService = superAdminService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateAdminOwner(Guid userId)
        {
            await _superAdminService.CreateAdminOwner(userId);
            return Ok();
        } 

        [HttpPost]
        public async Task<IActionResult> DeleteAdminOwner(Guid adminId)
        {
            await _superAdminService.DeleteAdminOwner(adminId);
            return Ok();
        }
    }
}
