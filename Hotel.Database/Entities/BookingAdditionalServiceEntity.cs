using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Database.Entities
{
    public class BookingAdditionalServiceEntity
    {
        public int Id { get; set; }

        public int BookingId { get; set; }

        public int AdditionalServiceId { get; set; }

        public DateTime StartDate { get; set; }

        public TimeSpan StartTime { get; set; }

        public DateTime EndDate { get; set; }

        public TimeSpan EndTime { get; set; }

        public virtual AdditionalServiceEntity AdditionalService { get; set; }

        public virtual BookingEntity Booking { get; set; }
    }
}
