using System;
using System.Collections.Generic;

namespace Business.DTO
{
    public class Booking
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid RoomId { get; set; }

        public DateTime ArrivalDate { get; set; }

        public TimeSpan ArrivalTime { get; set; }

        public DateTime DepartureDate { get; set; }

        public TimeSpan DepartureTime { get; set; }

        public Room Room { get; set; }
    }
}
