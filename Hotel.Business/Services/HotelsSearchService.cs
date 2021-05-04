using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using AutoMapper;
using Business.Interfaces;
using Business.Models;
using Database.Entities;
using Database.Interfaces;
using Serilog;

namespace Business.Services
{
    public class HotelsSearchService : IHotelsSearchService
    {
        private readonly IHotelsSearchRepository _hotelsSearchRepository;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public HotelsSearchService(IHotelsSearchRepository hotelsSearchRepository, ILogger logger, IMapper mapper)
        {
            _hotelsSearchRepository = hotelsSearchRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public List<HotelModel> Find(HotelsSearchModel searchModel)
        {
            IQueryable<HotelEntity> hotelEntities = null;

            if (string.IsNullOrEmpty(searchModel.Name))
            {
                hotelEntities = _hotelsSearchRepository.GetHotels().Where(h => h.Name.Equals(searchModel.Name));
            }

            if (string.IsNullOrEmpty(searchModel.Country))
            {
                hotelEntities = (hotelEntities ?? _hotelsSearchRepository.GetHotels()).Where(h => h.Country.Equals(searchModel.Country));
            }

            if (string.IsNullOrEmpty(searchModel.City))
            {
                hotelEntities = (hotelEntities ?? _hotelsSearchRepository.GetHotels()).Where(h => h.City.Equals(searchModel.City));
            }

            if (searchModel.StarsCount != 0)
            {
                hotelEntities = (hotelEntities ?? _hotelsSearchRepository.GetHotels()).Where(h => h.StarsCount >= searchModel.StarsCount).OrderBy(h => h.StarsCount);
            }

            if (searchModel.PriceFrom != 0)
            {
                hotelEntities = (hotelEntities ?? _hotelsSearchRepository.GetHotels().Where(h => h.PriceFrom >= searchModel.PriceFrom));
            }

            if (searchModel.PriceTo != 0)
            {
                hotelEntities = (hotelEntities ?? _hotelsSearchRepository.GetHotels().Where(h => h.PriceTo <= searchModel.PriceTo));
            }

            if (hotelEntities == null || !hotelEntities.Any())
            {
                return new List<HotelModel>();
            }

            return hotelEntities.Select(x => Mapper.Map<HotelEntity, HotelModel>(x)).ToList();
        }
    }
}
