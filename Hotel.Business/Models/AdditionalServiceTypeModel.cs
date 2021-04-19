using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{ 
    public class AdditionalServiceTypeModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<AdditionalServiceModel> AdditionalService { get; set; }
    }
}
