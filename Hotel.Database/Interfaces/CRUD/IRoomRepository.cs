using Database.Entities;
using System;
using System.Linq;

namespace Database.Interfaces.CRUD
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
