using System;
using System.Collections.Generic;

namespace Database.Entities
{
    public class PaymentTypeEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<PaymentResultEntity> PaymentResult { get; set; }
    }
}
