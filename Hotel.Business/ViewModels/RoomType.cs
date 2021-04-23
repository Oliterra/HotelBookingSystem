using System;
using System.Collections.Generic;

namespace Business.ViewModels
{
    public class RoomType
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Cost { get; set; }
    }
}
