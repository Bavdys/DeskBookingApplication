using AutoMapper;
using DeskBooking.Application.Dtos.RequestDtos;
using DeskBooking.Domain.Entities;

namespace DeskBooking.Application.Mapper
{
    public class RequestToDomainProfile : Profile
    {
        public RequestToDomainProfile()
        {
            CreateMap<CreateBookingRequest, Booking>();
        }
    }
}
