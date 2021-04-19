using Hotel.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
