using Hotel.Database.Entities;
using Hotel.Database.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Database.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly HotelContext _context;

        public BookingRepository(HotelContext context)
        {
            _context = context;
        }

        public void Add(BookingEntity booking)
        {
            try
            {
                _context.Bookings.Add(booking);
                _context.SaveChanges();
            }
            catch
            {
                throw new NotImplementedException();
            }       
        }

        public void Delete(Guid bookingId)
        {
            try
            {
                _context.Bookings.Remove(_context.Bookings.Where(x => x.Id == bookingId).FirstOrDefault());
                _context.SaveChanges();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public BookingEntity GetById(Guid bookingId)
        {
            try
            {
                return _context.Bookings.Where(x => x.Id == bookingId).FirstOrDefault();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public IQueryable<BookingEntity> GetQueryable()
        {
            return _context.Bookings;
        }

        public void Update(BookingEntity booking)
        {
            try
            {
                _context.Entry(booking).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
