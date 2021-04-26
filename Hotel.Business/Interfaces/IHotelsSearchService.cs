using System;
using System.Collections.Generic;
using System.Text;
using Business.Models;

namespace Business.Interfaces
{
    public interface IHotelsSearchService
    {

        List<HotelModel> Find(HotelsSearchModel searchModel);
        
        List<HotelModel> GetHotelsByName(string hotelName);

        List<HotelModel> GetHotelsByStarsCount(int starsCount);

        List<HotelModel> GetHotelsByCountry(string hotelCountry);

        List<HotelModel> GetHotelsByCity(string hotelCity);

        List<HotelModel> GetHotelsByPrice(int priceFrom, int priceTo);
    }

    public class HotelsSearchModel
    {
        public string City { get; set; }

        public string Country { get; set; }

        public string Name { get; set; }

        public int Star { get; set; }
    }
}
