﻿using System;
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

        public void Add(RoomEntity room)
        {
            try
            {
                _context.Rooms.Add(room);
                _context.SaveChanges();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public void Delete(Guid roomId)
        {
            try
            {
                _context.Rooms.Remove(_context.Rooms.Where(x => x.Id == roomId).FirstOrDefault());
                _context.SaveChanges();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public RoomEntity GetById(Guid roomId)
        {
            try
            {
                return _context.Rooms.Where(x => x.Id == roomId).FirstOrDefault();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public IQueryable<RoomEntity> GetQueryable()
        {
            return _context.Rooms;
        }

        public void Update(RoomEntity room)
        {
            try
            {
                _context.Entry(room).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
