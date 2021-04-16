using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Database.Entities
{
    public class PaymentResultEntity
    {
        public int Id { get; set; }

        public int BookingId { get; set; }

        public int PaymentTypeId { get; set; }

        public DateTime PaymentDate { get; set; }

        public TimeSpan PaymentTime { get; set; }

        public int PaymentSum { get; set; }

        public virtual BookingEntity Booking { get; set; }

        public virtual PaymentTypeEntity PaymentType { get; set; }
    }
}
   
