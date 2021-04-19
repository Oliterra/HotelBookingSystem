using Business.Models;
using Hotel.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Interfaces
{
    public interface IBookingService
    {
        BookingModel GetBookingById(Guid bookingId);

        bool AddBooking(BookingModel booking);

        bool UpdateBooking(BookingModel booking);

        bool DeleteBooking(Guid bookingId);
    }
}
