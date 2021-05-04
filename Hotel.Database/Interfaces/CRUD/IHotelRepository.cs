using Database.Entities;
using System;
using System.Linq;

namespace Database.Interfaces.CRUD
{
    public interface IHotelRepository
    {
        IQueryable<HotelEntity> GetQueryable();

        HotelEntity GetById(Guid hotelId);

        bool Add(HotelEntity hotel);

        bool Update(HotelEntity hotel);

        bool Delete(Guid hotelId);
    }
}
