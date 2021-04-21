using Database.Entities;
using System;
using System.Linq;

namespace Database.Interfaces
{
    public interface IUserRepository
    {
        IQueryable<UserEntity> GetQueryable();

        UserEntity GetById(Guid userId);

        bool Add(UserEntity user);

        bool Update(UserEntity user);

        bool Delete(Guid userId);
    }
}
