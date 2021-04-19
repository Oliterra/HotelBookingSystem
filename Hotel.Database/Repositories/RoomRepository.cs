using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Database.Interfaces;
using Hotel.Database;
using Hotel.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories
{
    class RoomRepository : IRoomRepository
    {
        private readonly HotelContext _context;

        public RoomRepository(HotelContext context)
        {
            _context = context;
        }

        public bool Add(RoomEntity room)
        {
            try
            {
                _context.Rooms.Add(room);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public bool Delete(Guid roomId)
        {
            try
            {
                _context.Rooms.Remove(_context.Rooms.Where(x => x.Id == roomId).FirstOrDefault());
                _context.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public RoomEntity GetById(Guid roomId)
        { 
            return _context.Rooms.Where(x => x.Id == roomId).FirstOrDefault();
        }

        public IQueryable<RoomEntity> GetQueryable()
        {
            return _context.Rooms;
        }

        public bool Update(RoomEntity room)
        {
            try
            {
                _context.Entry(room).State = EntityState.Modified;
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
