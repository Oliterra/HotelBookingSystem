using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Database.Entities
{
    public class PaymentResultEntity
    {
        public int PaymentResultId { get; set;}
        public int RoomPrice { get; set; }
        public int BookingId { get; set; }
        public int PaymentTypeId { get; set; }
        public string PaymentDate { get; set; }
        public string PaymentTime { get; set; }
        public BookingEntity Booking { get; set; }
        public PaymentTypeEntity PaymentType { get; set; }
    }
}
   
