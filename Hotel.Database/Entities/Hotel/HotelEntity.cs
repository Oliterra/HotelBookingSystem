using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBookingSystem.Models
{
    public class HotelEntity
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string StarsCount { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Img { get; set; }
        public bool IsFreeRooms { get; set; }
        public string RoomsCount { get; set; }
        public string FreeRoomsCount { get; set; }
        public bool IsFavorite { get; set; }

    }
}
