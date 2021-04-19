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
    class UserRepository : IUserRepository
    {
        private readonly HotelContext _context;

        public UserRepository(HotelContext context)
        {
            _context = context;
        }

        public bool Add(UserEntity user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public bool Delete(Guid userId)
        {
            try
            {
                _context.Users.Remove(_context.Users.Where(x => x.Id == userId).FirstOrDefault());
                _context.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public UserEntity GetById(Guid userId)
        {
            try
            {
                return _context.Users.Where(x => x.Id == userId).FirstOrDefault();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public IQueryable<UserEntity> GetQueryable()
        {
            return _context.Users;
        }

        public bool Update(UserEntity user)
        {
            try
            {
                _context.Entry(user).State = EntityState.Modified;
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
