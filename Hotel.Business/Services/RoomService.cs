using Business.Interfaces;
using Business.Models;
using Database.Interfaces;
using Hotel.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Services
{
    public class RoomService : IRoomService
    {
        private IRoomRepository _roomRepository;
        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public bool AddRoom(RoomModel room)
        {
            if (room == null)
            {
                throw new NullReferenceException("Room is null");
            }
            return _roomRepository.Add(Mapper.Map<RoomModel, RoomEntity>(room));
        }

        public bool DeleteRoom(Guid roomId)
        {
            if (roomId == null)
            {
                throw new NullReferenceException("Room id is incorrect");
            }
            return _roomRepository.Delete(roomId);
        }

        public RoomModel GetRoomById(Guid roomId)
        {
            if (roomId == null)
            {
                throw new NullReferenceException("Id is incorrect");
            }
            return Mapper.Map<RoomEntity, RoomModel>(_roomRepository.GetById(roomId));

        }

        public bool UpdateRoom(RoomModel room)
        {
            if (room == null)
            {
                throw new NullReferenceException("Room is null");
            }
            return _roomRepository.Update(Mapper.Map<RoomModel, RoomEntity>(room));
        }
    }
}
