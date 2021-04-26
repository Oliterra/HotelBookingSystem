using Business.Interfaces;
using Business.Models;
using Database.Entities;
using Database.Interfaces;
using System;

namespace Business.Services
{
    class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public bool AddBooking(BookingModel booking)
        {
            if (booking == null)
            {
                throw new NullReferenceException("Booking is null");
            }
            return _bookingRepository.Add(Mapper.Map<BookingModel, BookingEntity>(booking));
        }

        public bool DeleteBooking(Guid bookingId)
        {
            if (bookingId == null)
            {
                throw new NullReferenceException("Booking id is incorrect");
            }
            return _bookingRepository.Delete(bookingId);
        }

        public BookingModel GetBookingById(Guid bookingId)
        {
            if (bookingId == null)
            {
                throw new NullReferenceException("Id is incorrect");
            }
            return Mapper.Map<BookingEntity, BookingModel>(_bookingRepository.GetById(bookingId));

        }

        public bool UpdateBooking (BookingModel booking)
        {
            if (booking == null)
            {
                throw new NullReferenceException("Booking is null");
            }
            return _bookingRepository.Update(Mapper.Map<BookingModel, BookingEntity>(booking));
        }
    }
}
