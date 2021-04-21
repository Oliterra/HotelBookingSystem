using Business.Models;
using System;

namespace Business.Interfaces
{
    public interface IRoomService
    {
        RoomModel GetRoomById(Guid roomId);

        bool AddRoom(RoomModel room);

        bool UpdateRoom(RoomModel room);

        bool DeleteRoom(Guid roomId);
    }
}
