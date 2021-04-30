using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Threading.Tasks;

namespace Database
{
    public class DbInitializer
    {
        private static ILogger<DbInitializer> _logger;

        public DbInitializer(ILogger<DbInitializer> logger)
        {
            _logger = logger;
        }

        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<HotelContext>(); // uses the service provider to create an object that represents the type HotelContext

            context.Database.EnsureCreated(); // create the database if it doesn't exist

            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            var roleName = "SuperAdmin";

            IdentityResult result;

            var roleExist = await roleManager.RoleExistsAsync(roleName); // returns a flag indicating whether the specified object exists

            if (!roleExist)
            {
                result = await roleManager.CreateAsync(new IdentityRole(roleName));

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
                        result = await userManager.AddToRoleAsync(admin.ToString(), roleName);
                        
                        if (!result.Succeeded)
                        {
                            _logger.LogError("superadmin wasn't added");
                        }
                    }
                }
            }

            roleName = "AdministratorRole";

            if (!await roleManager.RoleExistsAsync(roleName))
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }
    }
}
