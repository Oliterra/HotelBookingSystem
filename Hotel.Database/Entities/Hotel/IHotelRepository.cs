using System;
using System.Collections.Generic;
using System.Text;
using HotelBookingSystem.Models;

namespace Hotel.Database.Entities
{
    public interface IHotelRepository // инкапсулирует уровень данных и содержит логику для извлечения данных и направлениях их к модели
    {
        IEnumerable<HotelEntity> Get();
        HotelEntity Get(int id);
        void Create(HotelEntity hotel);
        void Update(HotelEntity hotel);
        HotelEntity Delete(int id);
    }
}
