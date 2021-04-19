using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
