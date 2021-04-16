using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Database.Entities
{
    public class AdditionalServiceTypeEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<AdditionalServiceEntity> AdditionalService { get; set; }
    }
}
