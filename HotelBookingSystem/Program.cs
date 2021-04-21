using HotelBookingSystem;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // reads a config file (appsettings.json) and get the Configuration object for later use
            
            try
            {
                Log.Information("application starting");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal("The application failed to start");
            }
            finally
            {
                Log.CloseAndFlush(); // alows the logger to log any pending messages while the application closes down
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog() // to use serilog instead of default .NET logger
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
