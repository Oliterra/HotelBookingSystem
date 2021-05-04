using System;
using Business.Interfaces.CRUD;
using Business.Models;
using Database.Entities;
using Database.Interfaces.CRUD;

namespace Business.Services.CRUD
{
    public class RoomImageService : IRoomImageService
    {
        private readonly IRoomImageRepository _roomImageRepository;

        public RoomImageService(IRoomImageRepository roomImageRepository)
        {
            _roomImageRepository = roomImageRepository;
        }

        public bool AddRoomImage(RoomImageModel roomImage)
        {
            if (roomImage == null)
            {
                throw new NullReferenceException("Room image is incorrect");
            }
            return _roomImageRepository.Add(Mapper.Map<RoomImageModel, RoomImageEntity>(roomImage));
        }

        public bool DeleteRoomImage(Guid roomImageId)
        {
            if (roomImageId == null)
            {
                throw new NullReferenceException("Id is incorrect");
            }
            return _roomImageRepository.Delete(roomImageId);
        }

        public RoomImageModel GetRoomImageById(Guid roomImageId)
        {
            if (roomImageId == null)
            {
                throw new NullReferenceException("Id is incorrect");
            }
            return Mapper.Map<RoomImageEntity, RoomImageModel>(_roomImageRepository.GetById(roomImageId));
        }

        public bool UpdateRoomImage(RoomImageModel roomImage)
        {
            if (roomImage == null)
            {
                throw new NullReferenceException("Room image is incorrect");
            }
            return _roomImageRepository.Update(Mapper.Map<RoomImageModel, RoomImageEntity>(roomImage));
        }
    }
}
