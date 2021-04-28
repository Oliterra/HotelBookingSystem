using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Database.Entities;
using Database.Interfaces;

namespace Database.Repositories
{
    public class HotelsSearchRepository : IHotelsSearchRepository
    {
        private readonly HotelContext _context;

        public HotelsSearchRepository(HotelContext context)
        {
            _context = context;
        }
        public IQueryable<HotelEntity> GetHotels()
        {
            return _context.Hotels;
        }
    }
}

