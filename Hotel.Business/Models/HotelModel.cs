using System;
using System.Collections.Generic;

namespace Business.Models
{
    public class HotelModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int StarsNumber { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public int MinRoomPrice { get; set; }

        public bool IsFavorite { get; set; }

        public bool IsFreeRooms { get; set; }
    }
}
