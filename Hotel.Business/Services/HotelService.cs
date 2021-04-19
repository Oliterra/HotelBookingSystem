using Business.Interfaces;
using Business.Models;
using Database.Interfaces;
using HotelBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class HotelService : IHotelService
    {
        private IHotelRepository _hotelRepository;
        public HotelService(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }
        public bool AddHotel(HotelModel hotel)
        {
            if (hotel == null)
            {
                throw new NullReferenceException("Hotel is null");
            }
            return _hotelRepository.Add(Mapper.Map<HotelModel, HotelEntity>(hotel));
        }

        public bool DeleteHotel(Guid hotelId)
        {
            if (hotelId == null)
            {
                throw new NullReferenceException("Hotel id is incorrect");
            }
            return _hotelRepository.Delete(hotelId);
        }

        public HotelModel GetHotelById(Guid hotelId)
        {
            if (hotelId == null)
            {
                throw new NullReferenceException("Id is incorrect");
            }
            return Mapper.Map<HotelEntity, HotelModel>(_hotelRepository.GetById(hotelId));

        }

        public bool UpdateHotel(HotelModel hotel)
        {
            if (hotel == null)
            {
                throw new NullReferenceException("Hotel is null");
            }
            return _hotelRepository.Update(Mapper.Map<HotelModel, HotelEntity>(hotel));
        }
    }
}

