using Database.Entities;
using System;
using System.Linq;

namespace Database.Interfaces.CRUD
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
