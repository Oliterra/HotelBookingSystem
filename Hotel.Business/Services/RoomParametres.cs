using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Business.Interfaces;
using Business.Models;
using Database.Entities;
using Database.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Business.Services
{
    public class RoomParametres: IRoomParametres
    {
        private readonly IMapper _mapper;
        private readonly ILogger _logger;
        private readonly IIsFreeRepository _isFreeRepository;

        public RoomParametres(IMapper mapper, ILogger logger, IIsFreeRepository isFreeRepository)
        {
            _mapper = mapper;
            _logger = logger;
            _isFreeRepository = isFreeRepository;
        }
        
        // hotelEntities = (hotelEntities ?? _hotelsSearchRepository.GetHotels()).Where(h => h.Country.Equals(searchModel.Country));
        public List<RoomModel> SelectRoom(RoomSearchModel searchModel)
        {
            IQueryable<RoomEntity> roomEntities = null;

            if (string.IsNullOrEmpty(searchModel.Floor.ToString()))
            {
                roomEntities = _isFreeRepository.GetFreeRooms().Where(r => r.Floor.Equals(searchModel.Floor));
            }

            if (string.IsNullOrEmpty(searchModel.RoomsAmount.ToString()))
            {
                roomEntities = (roomEntities ?? _isFreeRepository.GetFreeRooms()).Where(r => r.RoomsAmount.Equals(searchModel.RoomsAmount));
            }

            if (string.IsNullOrEmpty(searchModel.SquareMeters.ToString()))
            {
                roomEntities = (roomEntities ?? _isFreeRepository.GetFreeRooms()).Where(r => r.SquareMeters.Equals(searchModel.SquareMeters));
            }

            if (string.IsNullOrEmpty(searchModel.Kitchen.ToString())) 
            {
                roomEntities = (roomEntities ?? _isFreeRepository.GetFreeRooms()).Where(r => r.Kitchen.Equals(searchModel.Kitchen));
            }

            if (string.IsNullOrEmpty(searchModel.Bathroom.ToString()))
            {
                roomEntities = (roomEntities ?? _isFreeRepository.GetFreeRooms()).Where(r => r.Bathroom.Equals(searchModel.Bathroom));
            }

            if (string.IsNullOrEmpty(searchModel.Conditioner.ToString()))
            {
                roomEntities = (roomEntities ?? _isFreeRepository.GetFreeRooms()).Where(r => r.Conditioner.Equals(searchModel.Conditioner));
            }

            if (string.IsNullOrEmpty(searchModel.Balcony.ToString()))
            {
                roomEntities = (roomEntities ?? _isFreeRepository.GetFreeRooms()).Where(r => r.Balcony.Equals(searchModel.Balcony));
            }

            if (string.IsNullOrEmpty(searchModel.Tv.ToString()))
            {
                roomEntities = (roomEntities ?? _isFreeRepository.GetFreeRooms()).Where(r => r.Tv.Equals(searchModel.Tv));
            }

            if (string.IsNullOrEmpty(searchModel.Fridge.ToString()))
            {
                roomEntities = (roomEntities ?? _isFreeRepository.GetFreeRooms()).Where(r => r.Fridge.Equals(searchModel.Fridge));
            }

            if (string.IsNullOrEmpty(searchModel.WashingMachine.ToString()))
            {
                roomEntities = (roomEntities ?? _isFreeRepository.GetFreeRooms()).Where(r => r.WashingMachine.Equals(searchModel.WashingMachine));
            }

            if (roomEntities == null || !roomEntities.Any())
            {
                return new List<RoomModel>();
            }

            return roomEntities.Select(x => _mapper.Map<RoomEntity, RoomModel>(x)).ToList();
        }
    }
}
