using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Database.Entities
{
    public class BookingAssignedUserEntity
    {
        public int BookingId { get; set; }

        public int PersonId { get; set; }

        public virtual BookingEntity Booking { get; set; }

        public virtual UserEntity User { get; set; }
    }
}
