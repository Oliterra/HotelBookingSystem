using System;
using System.Collections.Generic;
using System.Text;
using HotelBookingSystem.Models;

namespace Hotel.Database.Entities
{
    public class HotelClassEntity
    {
        public int HotelClassId { get; set; }

        public string HotelClassification { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public ICollection<HotelEntity> Hotels { get; set; }

    }
}

