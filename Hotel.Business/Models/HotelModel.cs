using System;
using System.Collections.Generic;

namespace Business.Models
{
    public class HotelModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int StarsCount { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public int PriceFrom { get; set; }

        public int PriceTo { get; set; }

        public string Address { get; set; }

        public bool IsFavorite { get; set; }

        public bool IsFreeRooms { get; set; }

        public HotelImageModel HotelImage { get; set; }
    }
}
