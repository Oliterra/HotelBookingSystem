using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Database
{
    public class DbInitializer
    {
        private static ILogger<DbInitializer> _logger;

        public DbInitializer(ILogger<DbInitializer> logger)
        {
            _logger = logger;
        }

        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<HotelContext>();

            context.Database.EnsureCreated();

            context.Database.Migrate();

            SeedUsers(serviceProvider).Wait();

            context.SaveChanges();
        }

        private static async Task SeedUsers(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            const string roleName = "SuperOnly";

            var roleExist = await roleManager.RoleExistsAsync(roleName);

            if (!roleExist)
            {
                var result = await roleManager.CreateAsync(new IdentityRole(roleName));

                if (result.Succeeded)
                {
                    var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

                    var config = serviceProvider.GetRequiredService<IConfiguration>();

                    var admin = await userManager.FindByEmailAsync(config["AdminCredentials:Email"]);

                    if (admin == null)
                    {
                        admin = new IdentityUser()
                        {
                            UserName = config["AdminCredentials:Email"],
                            Email = config["AdminCredentials:Email"],
                            EmailConfirmed = true
                        };
                    }

                    result = await userManager.CreateAsync(admin, config["AdminCredentials:Password"]);

                    if (result.Succeeded)
                    {
                        result = await userManager.AddToRoleAsync(admin, roleName);

                        if (!result.Succeeded)
                        {
                            _logger.LogError("Superadmin wasn't added");
                        }
                    }
                }
            }
        }
    }
}
