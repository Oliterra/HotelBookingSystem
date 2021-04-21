using System;
using System.Collections.Generic;

namespace Business.DTO
{
    public class RoomType
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Cost { get; set; }
    }
}
