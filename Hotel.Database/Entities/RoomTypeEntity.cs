using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Database.Entities
{
    public class RoomTypeEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Cost { get; set; }

        public ICollection<RoomEntity> Room { get; set; }
    }
}
