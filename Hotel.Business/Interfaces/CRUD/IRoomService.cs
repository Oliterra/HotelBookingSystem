using Business.Models;
using System;

namespace Business.Interfaces.CRUD
{
    public interface IRoomService
    {
        RoomModel GetRoomById(Guid roomId);

        bool AddRoom(RoomModel room);

        bool UpdateRoom(RoomModel room);

        bool DeleteRoom(Guid roomId);
    }
}
