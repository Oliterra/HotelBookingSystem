using HotelBookingSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Database
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {
           // Database.EnsureCreated();   // создаем базу данных при первом обращении
        }

        public DbSet<HotelEntity> Hotels { get; set; }
    }
}
