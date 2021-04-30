using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Threading.Tasks;
using Business.ViewModels.Authorization;
using Database;
using Database.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.Extensions.Logging;
using WebAPI.Interfaces;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebAPI.Services
{
    public class SuperAdminService : ISuperAdminService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly HotelContext _context;

        public SuperAdminService(UserManager<ApplicationUser> userManager, HotelContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task CreateAdminOwner(Guid userId)
        {
            var userStore = new UserStore<UserEntity>(_context);

            var user = _context.Users.Find(userId);

            userStore.AddToRoleAsync(user, "AdminOwner").Wait();

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAdminOwner(Guid adminId)
        {
            var userStore = new UserStore<UserEntity>(_context);

            var user = _context.Users.Find(adminId);

            userStore.RemoveFromRoleAsync(user, "AdminOwner").Wait();

            await _context.SaveChangesAsync();
        }
    }
}
