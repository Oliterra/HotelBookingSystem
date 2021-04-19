using Hotel.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database.Interfaces
{
    interface IRoomRepository
    {
        IQueryable<RoomEntity> GetQueryable();
        RoomEntity GetById(Guid roomId);
        void Add(RoomEntity room);
        void Update(RoomEntity room);
        void Delete(Guid roomId);
    }
}
