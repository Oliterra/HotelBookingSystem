using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Database.Entities;
using Database.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories
{
    public class SearchingRepository: ISearchingRepository
    {
        private readonly HotelContext _context;

        public SearchingRepository(HotelContext context)
        {
            _context = context;
        }

        public IQueryable<HotelEntity> GetHotels()
        {
            return _context.Hotels;
        }
    }
}
