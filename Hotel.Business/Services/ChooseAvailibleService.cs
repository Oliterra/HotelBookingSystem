using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Business.Interfaces;
using Business.Models;
using Database.Entities;
using Database.Interfaces;
using Microsoft.Extensions.Logging;

namespace Business.Services.CRUD
{
    public class ChooseAvailableService : IChooseAvailableService
    {
        private readonly ILogger _logger;
        private readonly IIsFreeRepository _isFreeRepository;
        private readonly IMapper _mapper;

        public ChooseAvailableService(ILogger logger, IIsFreeRepository isFreeRepository, IMapper mapper)
        {
            _logger = logger;
            _isFreeRepository = isFreeRepository;
            _mapper = mapper;
        }

        public List<HotelModel> GetAvailableHotels()
        {
            IQueryable<HotelEntity> hotelEntities = null;

            hotelEntities = _isFreeRepository.GetHotelsWithFreeRooms();

            if (hotelEntities == null || !hotelEntities.Any())
            {
                return new List<HotelModel>();
            }

            return hotelEntities.Select(x => _mapper.Map<HotelEntity, HotelModel>(x)).ToList();
        }

        public List<RoomModel> GetAvailableRooms()
        {
            IQueryable<RoomEntity> roomEntities = null;

            roomEntities = _isFreeRepository.GetFreeRooms();

            if (roomEntities == null || !roomEntities.Any())
            {
                return new List<RoomModel>();
            }

            return roomEntities.Select(x => _mapper.Map<RoomEntity, RoomModel>(x)).ToList();
        }
    }
}
