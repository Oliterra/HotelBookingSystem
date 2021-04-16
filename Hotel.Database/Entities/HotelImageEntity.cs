using HotelBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Database.Entities
{
    public class HotelImageEntity
    {
        public int Id { get; set; }

        public string HotelImage { get; set; }

        public virtual ICollection<HotelEntity> Hotel { get; set; }
    } 
}
