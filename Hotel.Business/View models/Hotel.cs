using System;
using System.Collections.Generic;

namespace Business.ViewModels
{
    public class Hotel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid ClassId { get; set; }

        public string StarsCount { get; set; }

        public string Country { get; set; }

        public string Address { get; set; }

        public string BuildingNumber { get; set; }

        public HotelClass HotelClass { get; set; }

        public HotelImage HotelImage { get; set; }
    }
}
