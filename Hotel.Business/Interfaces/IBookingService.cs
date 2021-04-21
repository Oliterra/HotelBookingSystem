using Business.Models;
using System;

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
