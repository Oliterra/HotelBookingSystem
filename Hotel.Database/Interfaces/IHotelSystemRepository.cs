using System;
using System.Linq;
using System.Threading.Tasks;

namespace Database.Interfaces
{
    public interface IHotelSystemRepository<TEntity> where TEntity : class
    {
        Task<IQueryable<TEntity>> GetAll();

        Task<TEntity> FindById(Guid id);

        Task Create(TEntity entity);

        Task Update(TEntity entity);

        Task Delete(TEntity entity);
    }
}