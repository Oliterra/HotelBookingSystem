using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Database.Entities
{
    public class RoomInfoEntity
    {
        public int RoomId { get; set; }

        public byte RoomsAmount { get; set; }

        public double SquareMeters { get; set; }

        public bool Kitchen { get; set; }

        public bool Bathroom { get; set; }

        public bool Conditioner { get; set; }

        public bool Balcony { get; set; }

        public bool Tv { get; set; }

        public bool WashingMachine { get; set; }

        public bool SoundIsolation { get; set; }

        public int ImageId { get; set; }

        public virtual RoomImageEntity Image { get; set; }

        public virtual RoomEntity Room { get; set; }
    }
}
