using DeskBooking.Application.Dtos.RequestDtos;
using DeskBooking.Application.Dtos.ResponseDtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeskBooking.Application.Interfaces
{
    public interface IBookingApplicationService
    {
        public Task<IEnumerable<BookingResponse>> GetAllBookings();
        public Task<BookingResponse> GetBookingById(Guid id);
        public Task<BookingResponse> CreateBooking(CreateBookingRequest createBookingRequest);
        public Task<BookingResponse> UpdateBooking(Guid id, UpdateBookingRequest updateBookingRequest);
        public Task<BookingResponse> DeleteBooking(Guid id);
    }
}
