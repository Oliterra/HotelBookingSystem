using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel.Database.Entities;

namespace HotelBookingSystem.Models
{
    public class HotelEntity
    {
        public int HotelId { get; set; }

        public string HotelName { get; set; }

        public int HotelClassId { get; set; }

        public string HotelStarsCount { get; set; }

        public string Country { get; set; }

        public string Address { get; set; }

        public string StreetId { get; set; }

        public string BuildingNumber { get; set; }

        public bool IsFavorite { get; set; }

        public bool IsFreeRooms { get; set; }

        public HotelClassEntity HotelClass { get; set; }

        public HotelImageEntity HotelImage { get; set; }

        public HotelStreetEntity HotelStreet { get; set; }

        public ICollection<BookingEntity> Booking { get; set; }
    }
}
/*
booking additional servise
 public int Id { get; set; }
        public int BookingId { get; set; }
        public int AdditionalServiceId { get; set; }
        public DateTime StartDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public DateTime? EndDate { get; set; }
        public TimeSpan? EndTime { get; set; }

        public AdditionalService AdditionalService { get; set; }
        public Booking Booking { get; set; }
booking assigned person
public int BookingId { get; set; }
        public int PersonId { get; set; }

        public Booking Booking { get; set; }
        public PersonInfo Person { get; set; }
booking status
public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Booking> Bookings { get; set; }
room 
public int Id { get; set; }
        public int HotelId { get; set; }
        public byte Floor { get; set; }
        public short Number { get; set; }
        public int RoomTypeId { get; set; }
        public int? SpecialCost { get; set; }

        public RoomType RoomType { get; set; }
        public RoomInfo RoomInfo { get; set; }
        public ICollection<Booking> Bookings { get; set; }