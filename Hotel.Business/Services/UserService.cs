using Business.Interfaces;
using Business.Models;
using Database.Interfaces;
using System;
using Database.Entities;

namespace Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool AddUser(UserModel user)
        {
            if (user == null)
            {
                throw new NullReferenceException("User is null");
            }
            return _userRepository.Add(Mapper.Map<UserModel, UserEntity>(user));
        }

        public bool DeleteUser(Guid userId)
        {
            if (userId == null)
            {
                throw new NullReferenceException("User id is incorrect");
            }
            return _userRepository.Delete(userId);
        }

        public UserModel GetUserId(Guid userId)
        {
            if (userId == null)
            {
                throw new NullReferenceException("Id is incorrect");
            }
            return Mapper.Map<UserEntity, UserModel>(_userRepository.GetById(userId));
        }

        public bool UpdateUser(UserModel user)
        {
            if (user == null)
            {
                throw new NullReferenceException("User is null");
            }
            return _userRepository.Update(Mapper.Map<UserModel, UserEntity>(user));
        }
    }
}
