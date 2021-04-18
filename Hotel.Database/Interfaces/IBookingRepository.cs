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
        void Add(BookingEntity booking);
        void Update(BookingEntity booking);
        void Delete(Guid bookingId);
    }
}
