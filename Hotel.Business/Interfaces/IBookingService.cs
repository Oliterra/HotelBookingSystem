using Hotel.Database.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IBookingService
    {
        BookingModel GetBooking(Guid bookingId);
        void AddBooking(BookingModel booking);
        void UpdateBooking(BookingModel booking);
        void DeleteBooking(Guid bookingId);
    }
}
