using Hotel.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database.Interfaces
{
    interface IRoomImageRepository
    {
        IQueryable<RoomImageEntity> GetQueryable();
        RoomImageEntity GetById(Guid roomImageId);
        void Add(RoomImageEntity roomImage);
        void Update(RoomImageEntity roomImage);
        void Delete(Guid roomImageId);
    }
}
