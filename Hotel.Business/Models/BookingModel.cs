using System;
using System.Collections.Generic;

namespace Business.Models
{
    public class BookingModel
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid RoomId { get; set; }

        public DateTime ArrivalDate { get; set; }

        public TimeSpan ArrivalTime { get; set; }

        public DateTime DepartureDate { get; set; }

        public TimeSpan DepartureTime { get; set; }

        public RoomModel Room { get; set; }

        public ICollection<BookingAdditionalServiceModel> BookingAdditionalService { get; set; }

        public ICollection<BookingAssignedUserModel> BookingAssignedPerson { get; set; }

        public ICollection<PaymentResultModel> PaymentResult { get; set; }
    }
}
