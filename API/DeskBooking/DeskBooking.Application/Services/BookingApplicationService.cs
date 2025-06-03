using AutoMapper;
using DeskBooking.Application.Dtos.RequestDtos;
using DeskBooking.Application.Dtos.ResponseDtos;
using DeskBooking.Application.Interfaces;
using DeskBooking.Domain.Core.Interfaces;
using DeskBooking.Domain.Entities;
using DeskBooking.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeskBooking.Application.Services
{
    public class BookingApplicationService : IBookingApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BookingApplicationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BookingResponse>> GetAllBookings()
        {
            var spec = new BookingsWithWorkspaceSpecification();
            var bookings = await _unitOfWork.Repository<Booking,Guid>().GetAsync(spec);
            var bookingsResponse = _mapper.Map<IReadOnlyList<Booking>, IReadOnlyList<BookingResponse>>(bookings);

            return bookingsResponse;
        }

        public async Task<BookingResponse> GetBookingById(Guid id)
        {
            var spec = new BookingsWithWorkspaceSpecification(id);
            var booking = await _unitOfWork.Repository<Booking,Guid>().GetEntityWithSpec(spec);
            var bookingResponse = _mapper.Map<Booking, BookingResponse>(booking);

            return bookingResponse;
        }

        public async Task<BookingResponse> CreateBooking(CreateBookingRequest createBookingRequest)
        {
            var booking = _mapper.Map<CreateBookingRequest, Booking>(createBookingRequest);
            await _unitOfWork.Repository<Booking, Guid>().AddAsync(booking);
            var bookingResponse = _mapper.Map<Booking, BookingResponse>(booking);

            return bookingResponse;
        }

        public async Task<BookingResponse> UpdateBooking(Guid id, UpdateBookingRequest updateBookingRequest)
        {
            var booking = await _unitOfWork.Repository<Booking, Guid>().GetByIdAsync(id);
            _mapper.Map(updateBookingRequest, booking);
            await _unitOfWork.Repository<Booking, Guid>().UpdateAsync(booking);
            var bookingResponse = _mapper.Map<Booking, BookingResponse>(booking);

            return bookingResponse;
        }

        public async Task<BookingResponse> DeleteBooking(Guid id)
        {
            var booking = await _unitOfWork.Repository<Booking, Guid>().GetByIdAsync(id);
            await _unitOfWork.Repository<Booking, Guid>().DeleteAsync(booking);
            var bookingResponse = _mapper.Map<Booking, BookingResponse>(booking);

            return bookingResponse;
        }
    }
}
