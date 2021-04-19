using Hotel.Database.Entities;
using HotelBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database.Interfaces
{
    interface IHotelRepository
    {
        IQueryable<HotelEntity> GetQueryable();
        HotelEntity GetById(Guid hotelId);
        void Add(HotelEntity hotel);
        void Update(HotelEntity hotel);
        void Delete(Guid hotelId);
    }
}
