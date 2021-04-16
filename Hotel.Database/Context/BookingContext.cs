using Hotel.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Database.Context
{
    class BookingContext
    {
        public BookingContext(DbContextOptions<BookingContext> options) : base(options)
        { 

        }
        public DbSet<BookingEntity> Bookings { get; set; }

    }
}
