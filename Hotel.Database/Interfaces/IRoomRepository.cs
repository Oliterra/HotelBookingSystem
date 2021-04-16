using Hotel.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Database.Interfaces
{
    interface IRoomRepository
    {
        IQueryable<RoomEntity> GetQueryable();
        RoomEntity GetRoomById(int id);
        bool AddRoom(RoomEntity room);
        bool UpdateRoom(RoomEntity room);
        bool DeleteRoom(int id);
        bool IsAvailable(int id);
    }
}
