using Hotel.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database.Interfaces
{
    public interface IHotelImageRepository
    {
        IQueryable<HotelImageEntity> GetQueryable();
        HotelImageEntity GetById(Guid hotelImageId);
        void Add(HotelImageEntity hotelImage);
        void Update(HotelImageEntity hotelImage);
        void Delete(Guid hotelImageId);
    }
}
