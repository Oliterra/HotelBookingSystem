using Business.Models;
using System;

namespace Business.Interfaces.CRUD
{
    public interface IUserService
    {
        UserModel GetUserId(Guid userId);

        bool AddUser (UserModel user);

        bool UpdateUser (UserModel user);

        bool DeleteUser (Guid userId);
    }
}
