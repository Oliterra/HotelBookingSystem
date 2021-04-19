using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class PaymentTypeModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<PaymentTypeModel> PaymentType { get; set; }
    }
}
