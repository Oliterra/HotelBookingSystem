using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Database.Entities
{
    public class BookingAssignedUserEntity
    {
        public Guid BookingId { get; set; }

        public BookingEntity Booking { get; set; }

        public UserEntity User { get; set; }
    }
}
