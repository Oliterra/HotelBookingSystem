using System;
using System.Collections.Generic;

namespace Business.ViewModels
{
    public class HotelClass
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public ICollection<Hotel> Hotel { get; set; }
    }
}
