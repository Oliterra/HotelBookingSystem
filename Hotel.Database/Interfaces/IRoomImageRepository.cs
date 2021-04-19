using Hotel.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database.Interfaces
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
