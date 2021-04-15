using HotelBookingSystem.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Hotel.Database.Entities
{
    public class HotelRepository: IHotelRepository
    {
        private HotelContext Context;

        public IEnumerable<HotelEntity> Get()
        {
            return Context.Hotels;
        }

        public HotelEntity Get(int Id)
        {
            return Context.Hotels.Find(Id);
        }
        public HotelRepository(HotelContext context)
        {
            Context = context;
        }
        public void Create(HotelEntity hotel)
        {
            Context.Hotels.Add(hotel);
            Context.SaveChanges();
        }
        public void Update(HotelEntity updatedHotelEntity)
        {
            HotelEntity currentHotel = Get(updatedHotelEntity.Id);
            currentHotel.IsFreeRooms = updatedHotelEntity.IsFreeRooms;
            currentHotel.StarsCount = updatedHotelEntity.StarsCount;
            currentHotel.ShortDescription = updatedHotelEntity.ShortDescription;
            currentHotel.LongDescription = updatedHotelEntity.LongDescription;
            currentHotel.FreeRoomsCount = updatedHotelEntity.FreeRoomsCount;
            Context.Hotels.Update(currentHotel);
            Context.SaveChanges();
        }

        public HotelEntity Delete(int Id)
        {
            HotelEntity hotelEntity = Get(Id);

            if (hotelEntity != null)
            {
                Context.Hotels.Remove(hotelEntity);
                Context.SaveChanges();
            }

            return hotelEntity;
        }


    }
}
