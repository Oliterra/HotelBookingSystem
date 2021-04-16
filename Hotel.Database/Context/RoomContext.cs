using Hotel.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Database.Context
{
    class BookingContext : DbContext
    {
        public BookingContext(DbContextOptions<BookingContext> options) : base(options)
        {

        }
        public DbSet<RoomEntity> Rooms { get; set; }

    }
}
