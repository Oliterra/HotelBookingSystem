using System;
using System.Collections.Generic;
using System.Text;
using HotelBookingSystem.Models;

namespace Hotel.Database.Entities
{
    public class BookingEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int RoomId { get; set; }

        public DateTime StartDate { get; set; }

        public TimeSpan StartTime { get; set; }

        public DateTime EndDate { get; set; }

        public TimeSpan EndTime { get; set; }

        public int BookingStatusId { get; set; }

        public virtual BookingStatusEntity BookingStatus { get; set; }

        public virtual RoomEntity Room { get; set; }

        public virtual ICollection<BookingAdditionalServiceEntity> BookingAdditionalService { get; set; }

        public virtual ICollection<BookingAssignedUserEntity> BookingAssignedPerson { get; set; }

        public virtual ICollection<PaymentResultEntity> PaymentResult { get; set; }
    }
} 
