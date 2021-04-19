using Business.Interfaces;
using Business.Models;
using Database.Interfaces;
using Hotel.Database.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class HotelImageService : IHotelImageService 
    {
        private IHotelImageRepository _hotelImageRepository;

        public HotelImageService (IHotelImageRepository hotelImageRepository)
        {
            _hotelImageRepository = hotelImageRepository;
        }

        public bool AddHotelImage(HotelImageModel hotelImage)
        {
            if (hotelImage == null)
            {
                throw new NullReferenceException("Hotel image is incorrect");
            }
            return _hotelImageRepository.Add(Mapper.Map<HotelImageModel, HotelImageEntity>(hotelImage));
        }

        public bool DeleteHotelImage(Guid hotelImageId)
        {
            if (hotelImageId == null)
            {
                throw new NullReferenceException("Id is incorrect");
            }
            return _hotelImageRepository.Delete(hotelImageId);
        }

        public HotelImageModel GetHotelImageById(Guid hotelImageId)
        {
            if (hotelImageId == null)
            {
                throw new NullReferenceException("Id is incorrect");
            }
            return Mapper.Map<HotelImageEntity, HotelImageModel>(_hotelImageRepository.GetById(hotelImageId));
        }

        public bool UpdateHotelImage(HotelImageModel hotelImage)
        {
            if (hotelImage == null)
            {
                throw new NullReferenceException("Hotel image is incorrect");
            }
            return _hotelImageRepository.Update(Mapper.Map<HotelImageModel, HotelImageEntity>(hotelImage));
        }
    }
}
