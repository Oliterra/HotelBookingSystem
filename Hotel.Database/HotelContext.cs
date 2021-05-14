using System;
using Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
        public DbSet<AdditionalServiceEntity> AdditionalServices { get; set; }
        public DbSet<BookingEntity> Bookings { get; set; }
        public DbSet<HotelEntity> Hotels { get; set; }
        public DbSet<HotelImageEntity> HotelImages { get; set; }
        public DbSet<RoomEntity> Rooms { get; set; }
        public DbSet<RoomImageEntity> RoomImages { get; set; }
        public DbSet<UserEntity> Users { get; set; }
    }
}
