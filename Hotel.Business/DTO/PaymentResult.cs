using System;

namespace Business.DTO
{
    public class PaymentResult
    {
        public Guid Id { get; set; }

        public Guid BookingId { get; set; }

        public Guid PaymentTypeId { get; set; }

        public DateTime PaymentDate { get; set; }

        public TimeSpan PaymentTime { get; set; }

        public int PaymentSum { get; set; }

        public Booking Booking { get; set; }

        public PaymentType PaymentType { get; set; }
    }
}
