using System;

namespace Database.Entities
{
    public class AdditionalServiceEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Cost { get; set; }

        public Guid AdditionalServiceTypeId { get; set; }

        public AdditionalServiceTypeEntity AdditionalServiceType { get; set; }
    }
}
