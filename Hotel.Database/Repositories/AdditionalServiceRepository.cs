using Database.Interfaces;
using Hotel.Database;
using Hotel.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database.Repositories
{
    class AdditionalServiceRepository : IAdditionalServiceRepository
    {
        private readonly HotelContext _context;

        public AdditionalServiceRepository(HotelContext context)
        {
            _context = context;
        }

        public void Add(AdditionalServiceEntity addServ)
        {
            try
            {
                _context.AdditionalServices.Add(addServ);
                _context.SaveChanges();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public void Delete(Guid addServId)
        {
            try
            {
                _context.AdditionalServices.Remove(_context.AdditionalServices.Where(x => x.Id == addServId).FirstOrDefault());
                _context.SaveChanges();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public AdditionalServiceEntity GetById(Guid addServId)
        {
            try
            {
                return _context.AdditionalServices.Where(x => x.Id == addServId).FirstOrDefault();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public IQueryable<AdditionalServiceEntity> GetQueryable()
        {
            return _context.AdditionalServices;
        }

        public void Update(AdditionalServiceEntity addServ)
        {
            try
            {
                _context.Entry(addServ).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
