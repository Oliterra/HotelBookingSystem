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
    class RoomImageRepository : IRoomImageRepository
    {
        private readonly HotelContext _context;

        public RoomImageRepository(HotelContext context)
        {
            _context = context;
        }

        public void Add(RoomImageEntity roomImage)
        {
            try
            {
                _context.RoomImages.Add(roomImage);
                _context.SaveChanges();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public void Delete(Guid roomImageId)
        {
            try
            {
                _context.RoomImages.Remove(_context.RoomImages.Where(x => x.Id == roomImageId).FirstOrDefault());
                _context.SaveChanges();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public RoomImageEntity GetById(Guid roomImageId)
        {
            try
            {
                return _context.RoomImages.Where(x => x.Id == roomImageId).FirstOrDefault();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public IQueryable<RoomImageEntity> GetQueryable()
        {
            return _context.RoomImages;
        }

        public void Update(RoomImageEntity roomImage)
        {
            try
            {
                _context.Entry(roomImage).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
