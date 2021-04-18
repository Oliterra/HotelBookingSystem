using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Database.Entities
{
    public class BookingAdditionalServiceModel
    {
        public Guid Id { get; set; }

        public Guid BookingId { get; set; }

        public Guid AdditionalServiceId { get; set; }

        public DateTime StartDate { get; set; }

        public TimeSpan StartTime { get; set; }

        public DateTime EndDate { get; set; }

        public TimeSpan EndTime { get; set; }

        public AdditionalServiceModel AdditionalService { get; set; }

        public BookingModel Booking { get; set; }
    }
}
