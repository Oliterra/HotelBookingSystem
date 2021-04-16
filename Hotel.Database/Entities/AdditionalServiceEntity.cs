using System.Collections.Generic;

namespace Hotel.Database.Entities
{
    public class AdditionalServiceEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Cost { get; set; }

        public int AdditionalServiceTypeId { get; set; }

        public virtual AdditionalServiceTypeEntity AdditionalServiceType { get; set; }

        public virtual ICollection<BookingAdditionalServiceEntity> BookingAdditionalService { get; set; }
    }
}
