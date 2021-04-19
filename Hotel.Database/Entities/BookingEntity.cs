using System;
using System.Collections.Generic;
using System.Text;
using HotelBookingSystem.Models;

namespace Hotel.Database.Entities
{
    public class BookingEntity
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid RoomId { get; set; }

        public DateTime StartDate { get; set; }

        public TimeSpan StartTime { get; set; }

        public DateTime EndDate { get; set; }

        public TimeSpan EndTime { get; set; }

        public bool BookingStatus { get; set; }

        public RoomEntity Room { get; set; }

        public ICollection<BookingAdditionalServiceEntity> BookingAdditionalService { get; set; }

        public ICollection<BookingAssignedUserEntity> BookingAssignedPerson { get; set; }

        public ICollection<PaymentResultEntity> PaymentResult { get; set; }
    }
} 
