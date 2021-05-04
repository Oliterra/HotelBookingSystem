using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Database.Entities;

namespace Database.Interfaces
{
    public interface IIsFreeRepository
    {
        IQueryable<HotelEntity> GetHotelsWithFreeRooms();

        IQueryable<RoomEntity> GetFreeRooms();
    }
}
