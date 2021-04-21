using System;
using System.Collections.Generic;

namespace Business.DTO
{
    public class HotelImage
    {
        public Guid Id { get; set; }

        public string Image { get; set; }

        public ICollection<Hotel> Hotel { get; set; }
    }
}
