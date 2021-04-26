using System;
using System.Collections.Generic;

namespace Database.Entities
{
    public class HotelEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid ClassId { get; set; }

        public int StarsCount { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string BuildingNumber { get; set; }

        public int PriceFrom { get; set; }

        public int PriceTo { get; set; }

        public bool IsFavorite { get; set; }

        public bool IsFreeRooms { get; set; }

        public HotelClassEntity HotelClass { get; set; }

        public HotelClassEntity HotelImage { get; set; }

        public ICollection<BookingEntity> Booking { get; set; }
    }
}
