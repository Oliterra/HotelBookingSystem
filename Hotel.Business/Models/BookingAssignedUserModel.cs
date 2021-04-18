using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Database.Entities
{
    public class BookingAssignedUserModel
    {
        public Guid BookingId { get; set; }

        public Guid PersonId { get; set; }

        public BookingModel Booking { get; set; }

        public UserModel User { get; set; }
    }
}
