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

            if (!string.IsNullOrEmpty(searchModel.Country))
            {
                hotelEntities = _hotelsSearchRepository.GetHotels().Where(h => h.Country.Equals(searchModel.Country));
            }

            if (!string.IsNullOrEmpty(searchModel.City))
            {
                hotelEntities = (hotelEntities ?? _hotelsSearchRepository.GetHotels()).Where(h => h.City.Equals(searchModel.City));
            }

            if (!string.IsNullOrEmpty(searchModel.MinRoomPrice.ToString()))
            {
                hotelEntities = (hotelEntities ?? _hotelsSearchRepository.GetHotels().Where(h => h.MinRoomPrice >= searchModel.MinRoomPrice));
            }

            if (hotelEntities == null || !hotelEntities.Any())
            {
                return new List<HotelModel>();
            }

            return hotelEntities
                .Select(h => _mapper.Map<HotelModel>(h))
                .ToList();
        }
    }
}
