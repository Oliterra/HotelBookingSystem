using Business.Interfaces;
using Database.Interfaces;
using Hotel.Database.Entities;
using Hotel.Database.Interfaces;
using Hotel.Database.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    class BookingService : IBookingService
    {
        private IBookingRepository _bookingRepository;
        private IRoomRepository _roomRepository;
        public BookingService(IBookingRepository bookingRepository, IRoomRepository roomRepository)
        {
            _bookingRepository = bookingRepository;
            _roomRepository = roomRepository;
        }

        public void AddBooking(BookingModel booking)
        {
            if (booking == null)
            {
                throw new NullReferenceException("Booking is null");
            }
            try
            {
                _bookingRepository.Add(booking);
            }
            catch
            {

            }
        }
        public void DeleteBooking(Guid bookingId)
        {
            if (bookingId == null)
            {
                throw new NullReferenceException("Booking id is incorrect");
            }

            _bookingRepository.Delete(bookingId);
        }
        public BookingModel GetBooking(Guid bookingId)
        {
            if (bookingId == null)
            {
                throw new NullReferenceException("Id is incorrect"); // возникает при попытке получить доступ к члену для типа, значение которого равно null
            }

            var booking = _bookingRepository.GetById(bookingId);
            return booking;
        }
        public void UpdateBooking(BookingModel booking)
        {
            if (booking == null)
            {
                throw new NullReferenceException("Booking is null");
            }
            _bookingRepository.Update(booking);
        }
    }
}
