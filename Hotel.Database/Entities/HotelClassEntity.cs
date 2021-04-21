using System;
using System.Collections.Generic;

namespace Database.Entities
{
    public class HotelClassEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public ICollection<HotelEntity> Hotel { get; set; }
    }
}

