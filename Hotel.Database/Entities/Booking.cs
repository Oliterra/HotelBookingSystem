using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Database.Entities
{
    class Booking
    {
        public string ArrivalDate { get; set; }

        public string DepartureDate { get; set; }

        public bool IsPaid { get; set; }

        public bool IsAdditionalServices { get; set; }
    }
}
