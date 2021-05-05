using Database.Entities;
using System;
using System.Linq;

namespace Database.Interfaces.CRUD
{
    public interface IRoomImageRepository
    {
        IQueryable<RoomImageEntity> GetQueryable();

        RoomImageEntity GetById(Guid roomImageId);

        bool Add(RoomImageEntity roomImage);

        bool Update(RoomImageEntity roomImage);

        bool Delete(Guid roomImageId);
    }
}
