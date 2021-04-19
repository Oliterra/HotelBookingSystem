using System;
using System.Collections.Generic;
using System.Text;
using HotelBookingSystem.Models;

namespace Hotel.Database.Entities
{
    public class BookingModel
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid RoomId { get; set; }

        public DateTime StartDate { get; set; }

        public TimeSpan StartTime { get; set; }

        public DateTime EndDate { get; set; }

        public TimeSpan EndTime { get; set; }

        public RoomModel Room { get; set; }

        public ICollection<BookingAdditionalServiceModel> BookingAdditionalService { get; set; }

        public ICollection<BookingAssignedUserModel> BookingAssignedPerson { get; set; }

        public ICollection<PaymentResultModel> PaymentResult { get; set; }
    }
} 
