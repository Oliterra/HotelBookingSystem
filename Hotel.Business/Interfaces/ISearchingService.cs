using System;
using System.Collections.Generic;
using System.Text;
using Business.Models;

namespace Business.Interfaces
{
    public interface ISearchingService
    {
        List<HotelModel> GetHotelsByName(string hotelName);

        List<HotelModel> GetHotelsByStarsCount(int starsCount);

        List<HotelModel> GetHotelsByCountry(string hotelCountry);

        List<HotelModel> GetHotelsByCity(string hotelCity);

        List<HotelModel> GetHotelsByPrice(int priceFrom, int priceTo);
    }
}
