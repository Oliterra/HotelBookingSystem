using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel.Database;
using Microsoft.AspNetCore.Http;
using System.Web.Http;
using Hotel.Database.Entities;

namespace HotelBookingSystem
{
    /* The Startup class is the input point to the application ASP.NET Core
       This class configures the application, configures the services that the application will use, and installs components for processing the request or middleware.
       When the application starts, the constructor is triggered first, then the Configure Services() method, and finally the Configure method() */
    public class Startup 
    {
        // The constructor is an optional part of the Startup class. In the constructor, the initial configuration of the application is usually performed.
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // ConfigureServices method is used to configure the app's . A service is a reusable component that provides app functionality. Services are registered ConfigureServices and consumed across the app via dependency injection (DI) or ApplicationServices. 
        // Optional. Called by the host before the Configure method to configure the app's services.
        public void ConfigureServices(IServiceCollection services) // Configure Services() represents a collection of services in the application.
        {
            // The extension methods of this object are used to configure the application to use the services. All methods have the form Add[service_name].
            services.AddControllers();// Adds services for controllers
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "test", Version = "v1" });
            });

            services.AddDbContext<HotelContext>(options => options.UseSqlServer("name=ConnectionStrings:db"));

            services.AddSingleton<IHotelRepository, HotelRepository>();

        }

        // Is used to specify how the app responds to HTTP requests
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) // The request pipeline is configured by adding middleware components to an IApplicationBuilder instance
        {
            // If the application is in the process development
            if (env.IsDevelopment())
            {
                // Then there will be an output information about the error, if there is an error
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "test v1"));

            }
            
            app.UseHttpsRedirection();

            // Routing is responsible for matching incoming HTTP requests and dispatching those requests to the app's executable endpoints
            app.UseRouting();

            // Builds the Authorization Middleware component into the pipeline, which manages user authorization and restricts access to resources
            app.UseAuthorization();

            // Allows to define routes that will be processed by the application
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "api/{controller}/{action=Index}");
            });




        }
    }
}
