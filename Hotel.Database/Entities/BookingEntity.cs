using System;
using System.Collections.Generic;
using System.Text;
using HotelBookingSystem.Models;

namespace Hotel.Database.Entities
{
    public class BookingEntity
    {
        public int BookingId { get; set; }

        public int UserId { get; set; }

        public int BookedHotelId { get; set; }

        public int BookedRoomId { get; set; }

        public string ArrivalDate { get; set; } // посмотреть формат для даты

        public string ArrivalTime { get; set; } // посмотреть формат для времени 

        public string DepartureDate { get; set; } // посмотреть формат для даты

        public string DepartureTime { get; set; } // посмотреть формат для времени

        public bool BookingStatusId { get; set; }

        public BookingStatusEntity BookingStatus { get; set; }

        public HotelEntity BookedHotel { get; set; }

        public HotelRoomEntity BookedRoom { get; set; }

        public ClientEntity Client { get; set; }

        public ICollection<AdditionalServicesEntity> AdditionalServices { get; set; }

        public ICollection<RoomGuestsEntity> RoomGuests { get; set; }

        public ICollection<PaymentTypeEntity> PaymentType { get; set; }
    }
} 
