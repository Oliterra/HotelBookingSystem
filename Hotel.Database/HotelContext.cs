using Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {
        }
        public DbSet<AdditionalServiceEntity> AdditionalServices { get; set; }
        public DbSet<AdditionalServiceTypeEntity> AdditionalServiceTypes { get; set; }
        public DbSet<BookingAdditionalServiceEntity> BookingAdditionalServices { get; set; }
        public DbSet<BookingAssignedUserEntity> BookingAssignedUsers { get; set; }
        public DbSet<BookingEntity> Bookings { get; set; }
        public DbSet<HotelClassEntity> HotelClasses { get; set; }
        public DbSet<HotelEntity> Hotels{ get; set; }
        public DbSet<HotelImageEntity> HotelImages { get; set; }
        public DbSet<PaymentResultEntity> PaymentResults { get; set; }
        public DbSet<PaymentTypeEntity> PaymentTypes { get; set; }
        public DbSet<RoomEntity> Rooms { get; set; }
        public DbSet<RoomImageEntity> RoomImages { get; set; }
        public DbSet<RoomTypeEntity> RoomTypes { get; set; }
        public DbSet<UserEntity> Users { get; set; }
    }
}
