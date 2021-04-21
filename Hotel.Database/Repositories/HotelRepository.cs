using Database.Entities;
using Database.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Database.Repositories
{
    class HotelRepository : IHotelRepository
    {
        private readonly HotelContext _context;

        public HotelRepository(HotelContext context)
        {
            _context = context;
        }

        public bool Add(HotelEntity hotel)
        {
            try
            {
                _context.Hotels.Add(hotel);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public bool Delete(Guid hotelId)
        {
            try
            {
                _context.Hotels.Remove(_context.Hotels.Where(x => x.Id == hotelId).FirstOrDefault());
                _context.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public HotelEntity GetById(Guid hotelId)
        {
            try
            {
                return _context.Hotels.Where(x => x.Id == hotelId).FirstOrDefault();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public IQueryable<HotelEntity> GetQueryable()
        {
            return _context.Hotels;
        }

        public bool Update(HotelEntity hotel)
        {
            try
            {
                _context.Entry(hotel).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }
    }
}
