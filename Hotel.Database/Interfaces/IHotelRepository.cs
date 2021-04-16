using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelBookingSystem.Models;

namespace Hotel.Database.Entities
{
    public interface IHotelRepository 
    {
        IQueryable<HotelEntity> GetQueryable(); //Объект IQueryable предоставляет удаленный доступ к базе данных и позволяет перемещаться по данным как от начала до конца, так и в обратном порядке
        HotelEntity GetHotelById(int id);
        void AddHotel(HotelEntity hotel);
        void UpdateHotel(HotelEntity hotel);
        void DeleteHotel(int id);
    }
}
