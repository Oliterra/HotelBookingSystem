using System;
using System.Collections.Generic;

namespace Business.Models
{
    public class AdditionalServiceModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Cost { get; set; }

        public Guid AdditionalServiceTypeId { get; set; }

        public AdditionalServiceTypeModel AdditionalServiceType { get; set; }

        public ICollection<BookingAdditionalServiceModel> BookingAdditionalService { get; set; }
    }
}
