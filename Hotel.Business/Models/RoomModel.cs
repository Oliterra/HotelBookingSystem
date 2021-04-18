using HotelBookingSystem.Models;
using System;
using System.Collections.Generic;

namespace Hotel.Database.Entities
{
    public class RoomModel
    {
        public Guid Id { get; set; }

        public Guid HotelId { get; set; }

        public byte Floor { get; set; }

        public short Number { get; set; }

        public Guid RoomTypeId { get; set; }

        public int Price { get; set; }

        public HotelModel Hotel { get; set; }

        public RoomTypeModel RoomType { get; set; }

        public ICollection<BookingModel> Booking { get; set; }
    }
}
