using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;

namespace HotelBookingSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // reads a config file (appsettings.json) and get the Configuration object for later use
            var config = new ConfigurationBuilder() 
                .AddJsonFile("appsettings.json")
                .Build();

            // initializes the Serilog using the settings fron appsetting.json
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(config)
                .CreateLogger();
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
                Log.CloseAndFlush(); // alows the logger to liog any pending messaes while the application closes down
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
