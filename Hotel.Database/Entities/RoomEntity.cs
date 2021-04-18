using HotelBookingSystem.Models;
using System;
using System.Collections.Generic;

namespace Hotel.Database.Entities
{
    public class RoomEntity
    {
        public Guid Id { get; set; }

        public Guid HotelId { get; set; }

        public int Floor { get; set; }

        public int Number { get; set; }

        public Guid RoomTypeId { get; set; }

        public Guid RoomImageId { get; set; }

        public int Price { get; set; }

        public byte RoomsAmount { get; set; }

        public double SquareMeters { get; set; }

        public bool Kitchen { get; set; }

        public bool Bathroom { get; set; }

        public bool Conditioner { get; set; }

        public bool Balcony { get; set; }

        public bool Tv { get; set; }

        public bool Fridge { get; set; }

        public bool WashingMachine { get; set; }

        public ICollection<BookingEntity> Booking { get; set; }
    }
}
