using Database.Entities;
using System;
using System.Linq;

namespace Database.Interfaces.CRUD
{
    public interface IHotelImageRepository
    {
        IQueryable<HotelImageEntity> GetQueryable();

        HotelImageEntity GetById(Guid hotelImageId);

        bool Add(HotelImageEntity hotelImage);

        bool Update(HotelImageEntity hotelImage);

        bool Delete(Guid hotelImageId);
    }
}
