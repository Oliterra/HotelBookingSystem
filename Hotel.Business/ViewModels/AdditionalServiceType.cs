using System;
using System.Collections.Generic;

namespace Business.ViewModels
{
    public class AdditionalServiceType
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<AdditionalService> AdditionalService { get; set; }
    }
}
