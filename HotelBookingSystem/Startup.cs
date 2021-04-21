using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Hotel.Database;
using Microsoft.AspNetCore.Http;
using Serilog;
using System.Net;
using Microsoft.AspNetCore.Diagnostics;

namespace HotelBookingSystem
{
    public class Startup 
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            // initializes the Serilog using the settings fron appsetting.json
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(config)
                .CreateLogger();
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) 
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "test", Version = "v1" });
            });

            services.AddDbContext<HotelContext>(options => options.UseSqlServer("name=ConnectionStrings:db"));
            services.AddControllers();
        }
        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) 
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "test v1"));

            }
            
            app.UseHttpsRedirection();

            app.UseExceptionHandler(
                options =>
                {
                    options.Run(
                        async context =>
                        {
                            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                            context.Response.ContentType = "text/html";
                            var exceptionObject = context.Features.Get<IExceptionHandlerFeature>();
                            if (null != exceptionObject)
                            {
                                var errorMessage = $"<b>Exception Error: {exceptionObject.Error.Message} </b> {exceptionObject.Error.StackTrace}";
                                await context.Response.WriteAsync(errorMessage).ConfigureAwait(false);
                            }
                        });
                }
            );

            app.UseStaticFiles();

            app.UseSerilogRequestLogging();

            app.UseRouting();

            app.UseAuthorization();

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
