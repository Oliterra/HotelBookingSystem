using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Interfaces;
using Business.Models;
using Business.ViewModels;
using Database.Entities;
using Database.Interfaces;
using Database.Repositories;

namespace Business.Services
{
    public class SearchingService : ISearchingService
    {
        private readonly ISearchingRepository _searchingRepository;

        public SearchingService(ISearchingRepository searchingRepository)
        {
            _searchingRepository = searchingRepository;
        }
        public List<HotelModel> GetHotelsByName(string hotelName)
        {
            List<HotelModel> result = new List<HotelModel>();
            IQueryable<HotelEntity> query = _searchingRepository.GetHotels().OrderBy(x => x.Name);

            if (hotelName != null)
                query = query.Where(x => x.Name.Contains(hotelName) || x.Name.StartsWith(hotelName) || x.Name.EndsWith(hotelName));
          
            foreach (HotelEntity hotel in query.ToList())
            {
                result.Add(Mapper.Map<HotelEntity, HotelModel>(hotel));
            }
            return result;
        }

        public List<HotelModel> GetHotelsByStarsCount(int starsCount)
        {
            List<HotelModel> result = new List<HotelModel>();
            IQueryable<HotelEntity> query = _searchingRepository.GetHotels().OrderBy(x => x.StarsCount);

            if (starsCount != 0)
                query = query.Where(x => x.StarsCount == starsCount);

            foreach (HotelEntity hotel in query.ToList())
            {
                result.Add(Mapper.Map<HotelEntity, HotelModel>(hotel));
            }
            return result;
        }

        public List<HotelModel> GetHotelsByCountry(string hotelCountry)
        {
            List<HotelModel> result = new List<HotelModel>();
            IQueryable<HotelEntity> query = _searchingRepository.GetHotels().OrderBy(x => x.Country);

            if (hotelCountry != null)
                query = query.Where(x => x.Country == hotelCountry);

            foreach (HotelEntity hotel in query.ToList())
            {
                result.Add(Mapper.Map<HotelEntity, HotelModel>(hotel));
            }
            return result;
        }

        public List<HotelModel> GetHotelsByCity(string hotelCity)
        {
            List<HotelModel> result = new List<HotelModel>();
            IQueryable<HotelEntity> query = _searchingRepository.GetHotels().OrderBy(x => x.City);

            if (hotelCity != null)
                query = query.Where(x => x.City == hotelCity);

            foreach (HotelEntity hotel in query.ToList())
            {
                result.Add(Mapper.Map<HotelEntity, HotelModel>(hotel));
            }
            return result;
        }

        public List<HotelModel> GetHotelsByPrice(int priceFrom, int priceTo)
        {
            List<HotelModel> result = new List<HotelModel>();
            IQueryable<HotelEntity> query = _searchingRepository.GetHotels().OrderBy(x => x.City);

            if (priceFrom != 0 && priceTo != 0)
                query = query.Where(x => x.PriceFrom >= priceFrom).Where(x => x.PriceTo <= priceTo);

            foreach (HotelEntity hotel in query.ToList())
            {
                result.Add(Mapper.Map<HotelEntity, HotelModel>(hotel));
            }
            return result;
        }
    }
}
