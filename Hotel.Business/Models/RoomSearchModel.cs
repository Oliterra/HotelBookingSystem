using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Models
{
    public class RoomSearchModel
    {
        public int Floor { get; set; }

        public byte RoomsAmount { get; set; }

        public double SquareMeters { get; set; }

        public bool Kitchen { get; set; }

        public bool Bathroom { get; set; }

        public bool Conditioner { get; set; }

        public bool Balcony { get; set; }

        public bool Tv { get; set; }

        public bool Fridge { get; set; }

        public bool WashingMachine { get; set; }
    }
}
