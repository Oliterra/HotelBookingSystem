using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class HotelsSearchModel
    {
        public string Name { get; set; }

        public int StarsCount { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public int PriceFrom { get; set; }

        public int PriceTo { get; set; }
    }
}
