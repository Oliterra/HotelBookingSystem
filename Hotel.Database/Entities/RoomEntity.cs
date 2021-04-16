using HotelBookingSystem.Models;
using System.Collections.Generic;

namespace Hotel.Database.Entities
{
    public class RoomEntity
    {
        public int Id { get; set; }

        public int HotelId { get; set; }

        public byte Floor { get; set; }

        public short Number { get; set; }

        public int RoomTypeId { get; set; }

        public int Price { get; set; }

        public virtual HotelEntity Hotel { get; set; }

        public virtual RoomTypeEntity RoomType { get; set; }

        public virtual RoomInfoEntity RoomInfo { get; set; }

        public virtual ICollection<BookingEntity> Booking { get; set; }
    }
}
