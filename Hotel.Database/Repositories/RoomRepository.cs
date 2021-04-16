using Hotel.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Database.Repositories
{
    class RoomRepository : IRoomRepository
    {
        private readonly HotelContext Context;
        public HotelRepository(HotelContext context)
        {
            Context = context;
        }
        public IQueryable<HotelEntity> GetQueryable()
        {
            return Context.Hotels;
        }
        public HotelEntity GetHotelById(int id)
        {
            try
            {
                return Context.Hotels.Where(x => x.Id == id).FirstOrDefault();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public void AddHotel(HotelEntity hotel)
        {
            try
            {
                Context.Hotels.Add(hotel);
                Context.SaveChanges();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
        public void UpdateHotel(HotelEntity hotel)
        {
            try
            {
                Context.Entry(hotel).State = EntityState.Modified;
                Context.SaveChanges();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public void DeleteHotel(int id)
        {
            try
            {
                Context.Hotels.Remove(Context.Hotels.Where(x => x.Id == id).FirstOrDefault());
                Context.SaveChanges();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
