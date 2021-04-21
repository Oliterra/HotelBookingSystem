using System;

namespace Database.Entities
{
    public class PaymentResultEntity
    {
        public Guid Id { get; set; }

        public Guid BookingId { get; set; }

        public Guid PaymentTypeId { get; set; }

        public DateTime PaymentDate { get; set; }

        public TimeSpan PaymentTime { get; set; }

        public int PaymentSum { get; set; }

        public BookingEntity Booking { get; set; }

        public PaymentTypeEntity PaymentType { get; set; }
    }
}
   
