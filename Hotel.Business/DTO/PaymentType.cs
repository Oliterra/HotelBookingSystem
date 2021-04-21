using System;
using System.Collections.Generic;

namespace Business.DTO
{
    public class PaymentType
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
