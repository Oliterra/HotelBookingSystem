using System;
using System.Collections.Generic;

namespace Business.Models
{
    public class HotelClassModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public ICollection<HotelModel> Hotel { get; set; }
    }
}

