using Hotel.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hotel.Database.Interfaces
{
    class IBookingRepository
    {
        IQueryable<RoomEntity> GetQueryable();
        RoomEntity GetRoomById(int id);
        void AddRoom(RoomEntity room);
        void UpdateRoom(RoomEntity room);
        void DeleteRoom(int id);
        void IsAvailable(int id);
    }
}
