using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class RoomTypeModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Cost { get; set; }

        public ICollection<RoomModel> Room { get; set; }
    }
}
