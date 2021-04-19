using Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IUserService
    {
        UserModel GetUserId(Guid userId);

        bool AddUser (UserModel user);

        bool UpdateUser (UserModel user);

        bool DeleteUser (Guid userId);
    }
}
