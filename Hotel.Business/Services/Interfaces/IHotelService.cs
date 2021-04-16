using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Business.Services.Interfaces
{
    class IHotelservice
    {
        List<HotelModel> GetHotels();
        List<HotelModel> GetHotels(string name, string city, string pincode);
        HotelModel GetHotelById(int id);
        bool AddHotel(HotelModel hotel);
        bool DeleteHotel(int id);
        bool UpdateHotel(HotelModel hotel);
    }
}
