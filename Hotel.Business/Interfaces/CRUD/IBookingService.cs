using Business.Models;
using System;

namespace Business.Interfaces.CRUD
{
    public interface IBookingService
    {
        BookingModel GetBookingById(Guid bookingId);

        bool AddBooking(BookingModel booking);

        bool UpdateBooking(BookingModel booking);

        bool DeleteBooking(Guid bookingId);
    }
}
