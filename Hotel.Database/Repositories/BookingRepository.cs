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

        public bool Add(BookingEntity booking)
        {
            try
            {
                _context.Bookings.Add(booking);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }       
        }

        public bool Delete(Guid bookingId)
        {
            try
            {
                _context.Bookings.Remove(_context.Bookings.Where(x => x.Id == bookingId).FirstOrDefault()); // FirstOrDefault выбирает первый элемент коллекции или возвращает значение по умолчанию
                _context.SaveChanges();
                return true;
            }
            catch
            {
                throw;
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

        public bool Update(BookingEntity booking)
        {
            try
            {
                _context.Entry(booking).State = EntityState.Modified; // cостояние сущностного объекта указывается через свойство DbSet.Entry, для указания на то, что объект изменился используется значение EntityState.Modified
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
