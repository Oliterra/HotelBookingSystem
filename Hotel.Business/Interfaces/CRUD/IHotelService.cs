using Business.Models;
using System;

namespace Business.Interfaces.CRUD
{
    public interface IHotelService
    {
        HotelModel GetHotelById(Guid hotelId);

        bool AddHotel(HotelModel hotel);

        bool UpdateHotel(HotelModel hotel);

        bool DeleteHotel(Guid hotelId);
    }
}
