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

namespace HotelBookingSystem
{
    // Настраивает службы и конвейер запросов приложения.
    // Указывается при сборке хоста приложения.
    public class Startup
    {
        //Выполняет настройку приложения с помощью поставщика конфигурации.
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Необязательный метод ConfigureServices() регистрирует сервисы, которые используются приложением. 
        public void ConfigureServices(IServiceCollection services) // В качестве параметра метод ConfigureServices() принимает объект IServiceCollection, который представляет коллекцию сервисов в приложении.
        {
            // С помощью методов расширений этого объекта производится конфигурация приложения для использования сервисов. Все методы имеют форму Add[название_сервиса].
            services.AddControllers();// Добавляет сервисы для контроллеров
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "test", Version = "v1" });
            });

            services.AddDbContext<HotelContext>(       options => options.UseSqlServer("name=ConnectionStrings:db"));
        }

        // Метод Configure устанавливает, как приложение будет обрабатывать запрос. Этот метод является обязательным.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) //Для установки компонентов, которые обрабатывают запрос
        {
            // если приложение в процессе разработки
            if (env.IsDevelopment())
            {
                // то выводим информацию об ошибке, при наличии ошибки
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "test v1"));
            }
            
            app.UseHttpsRedirection();
            
            // добавляем возможности маршрутизации
            app.UseRouting();

            // Добавляет промежуточное программное обеспечение, которое включает возможности авторизации.
            app.UseAuthorization();

            // устанавливаем адреса, которые будут обрабатываться
            app.UseEndpoints(endpoints =>
            {
                // Добавляет конечные точки для действий контроллера
                endpoints.MapControllers();
            });

        }
    }
}
