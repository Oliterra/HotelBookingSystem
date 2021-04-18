using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Database.Interfaces;
using Hotel.Database;
using HotelBookingSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories
{
    class HotelRepository : IHotelRepository
    {
        private readonly HotelContext _context;

        public HotelRepository(HotelContext context)
        {
            _context = context;
        }

        public void Add(HotelEntity hotel)
        {
            try
            {
                _context.Hotels.Add(hotel);
                _context.SaveChanges();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public void Delete(Guid hotelId)
        {
            try
            {
                _context.Hotels.Remove(_context.Hotels.Where(x => x.Id == hotelId).FirstOrDefault());
                _context.SaveChanges();
            }
            catch
            {
                throw new NotImplementedException();
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

        public void Update(HotelEntity hotel)
        {
            try
            {
                _context.Entry(hotel).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
