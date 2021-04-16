using HotelBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Database.Entities
{
    public class HotelStreetEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CityId { get; set; }

        public virtual HotelCityEntity City { get; set; }

        public virtual ICollection<HotelEntity> Hotel { get; set; }
    }
}
