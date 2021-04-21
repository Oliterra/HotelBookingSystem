using System;
using System.Collections.Generic;

namespace Database.Entities
{
    public class AdditionalServiceTypeEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<AdditionalServiceEntity> AdditionalService { get; set; }
    }
}
