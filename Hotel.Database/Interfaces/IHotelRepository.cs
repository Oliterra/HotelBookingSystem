using Hotel.Database.Entities;
using HotelBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database.Interfaces
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
