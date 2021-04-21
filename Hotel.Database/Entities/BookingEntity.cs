using System;
using System.Collections.Generic;

namespace Database.Entities
{
    public class BookingEntity
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid RoomId { get; set; }

        public DateTime ArrivalDate { get; set; }

        public TimeSpan ArrivalTime { get; set; }

        public DateTime DepartureDate { get; set; }

        public TimeSpan DepartupeTime { get; set; }

        public bool BookingStatus { get; set; }

        public RoomEntity Room { get; set; }

        public ICollection<BookingAdditionalServiceEntity> BookingAdditionalService { get; set; }

        public ICollection<BookingAssignedUserEntity> BookingAssignedPerson { get; set; }

        public ICollection<PaymentResultEntity> PaymentResult { get; set; }
    }
} 
