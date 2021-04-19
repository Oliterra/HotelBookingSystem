using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class BookingAssignedUserModel
    {
        public Guid BookingId { get; set; }

        public Guid PersonId { get; set; }

        public BookingModel Booking { get; set; }

        public UserModel User { get; set; }
    }
}
