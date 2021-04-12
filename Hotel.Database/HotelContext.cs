using HotelBookingSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Database
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {
            
        }

        public DbSet<HotelEntity> Hotels { get; set; }
    }
}
