using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories
{
    public class HotelSystemRepository<TEntity>: IHotelSystemRepository<TEntity> where TEntity : class
    {
        private readonly HotelContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public HotelSystemRepository (HotelContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task Create(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<TEntity> FindById(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task Delete (TEntity entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<IQueryable<TEntity>> GetAll()
        {
            return await Task.FromResult(_dbSet.AsNoTracking());
        }
    }
}
