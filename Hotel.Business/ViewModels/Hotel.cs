using System;
using System.Collections.Generic;

namespace Business.ViewModels
{
    public class Hotel
    {
        public string Name { get; set; }

        public string StarsCount { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public double PriceFrom { get; set; }

        public double PriceTo { get; set; }

        public string Address { get; set; }

        public HotelImage HotelImage { get; set; }
    }
}
