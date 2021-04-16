using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Database.Entities
{
    public class RoomImageEntity
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public virtual ICollection<RoomInfoEntity> RoomInfo { get; set; }
    }
}
