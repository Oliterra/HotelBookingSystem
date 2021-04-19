using Hotel.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database.Interfaces
{
    public interface IRoomRepository
    {
        IQueryable<RoomEntity> GetQueryable();

        RoomEntity GetById(Guid roomId);

        bool Add(RoomEntity room);

        bool Update(RoomEntity room);

        bool Delete(Guid roomId);
    }
}
