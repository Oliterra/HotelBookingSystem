using System;
using System.Collections.Generic;

namespace Business.Models
{
    public class HotelImageModel
    {
        public Guid Id { get; set; }

        public string HotelImage { get; set; }

        public ICollection<HotelModel> Hotel { get; set; }
    } 
}
