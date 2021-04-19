using Hotel.Database.Entities;
using HotelBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Database.Interfaces
{
    public interface IBookingRepository
    {
        IQueryable<BookingEntity> GetQueryable();

        BookingEntity GetById(Guid bookingId);

        bool Add(BookingEntity booking);

        bool Update(BookingEntity booking);

        bool Delete(Guid bookingId);
    }
}
