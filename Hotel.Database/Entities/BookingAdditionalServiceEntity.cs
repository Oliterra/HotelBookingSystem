using System;

namespace Database.Entities
{
    public class BookingAdditionalServiceEntity
    {
        public Guid Id { get; set; }

        public Guid BookingId { get; set; }

        public Guid AdditionalServiceId { get; set; }

        public DateTime StartDate { get; set; }

        public TimeSpan StartTime { get; set; }

        public DateTime EndDate { get; set; }

        public TimeSpan EndTime { get; set; }

        public AdditionalServiceEntity AdditionalService { get; set; }

        public BookingEntity Booking { get; set; }
    }
}
