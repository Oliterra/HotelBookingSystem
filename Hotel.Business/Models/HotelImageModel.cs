using HotelBookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class HotelImageModel
    {
        public Guid Id { get; set; }

        public string HotelImage { get; set; }

        public ICollection<HotelModel> Hotel { get; set; }
    } 
}
