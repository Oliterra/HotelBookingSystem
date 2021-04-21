using System;

namespace Business.Models
{
    public class PaymentResultModel
    {
        public Guid Id { get; set; }

        public Guid BookingId { get; set; }

        public Guid PaymentTypeId { get; set; }

        public DateTime PaymentDate { get; set; }

        public TimeSpan PaymentTime { get; set; }

        public int PaymentSum { get; set; }

        public BookingModel Booking { get; set; }

        public PaymentTypeModel PaymentType { get; set; }
    }
}
   
