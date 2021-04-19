using Hotel.Database.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IBookingService
    {
        string AddBooking(BookingModel booking);
        IList<BookingModel> GetByUserId(Guid id);

    }
}
