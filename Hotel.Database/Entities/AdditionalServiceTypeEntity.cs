using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Database.Entities
{
    public class AdditionalServiceTypeEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<AdditionalServiceEntity> AdditionalService { get; set; }
    }
}
