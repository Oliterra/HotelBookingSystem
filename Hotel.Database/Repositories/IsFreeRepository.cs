using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Database.Entities;
using Database.Interfaces;

namespace Database.Repositories
{
    public class IsFreeRepository : IIsFreeRepository
    {
        private readonly HotelContext _context;

        public IsFreeRepository(HotelContext context)
        {
            _context = context;
        }

        public IQueryable<HotelEntity> GetHotelsWithFreeRooms()
        {
            IQueryable<HotelEntity> hotels = _context.Hotels;
            return hotels.Where(f => f.IsFreeRooms == true);
        }

        public IQueryable<RoomEntity> GetFreeRooms()
        {
            IQueryable<RoomEntity> rooms = _context.Rooms;
            return rooms.Where(f => f.IsFree == true);
        }
    }
}
