using AutoMapper;
using DeskBooking.Application.Dtos.ResponseDtos;
using DeskBooking.Domain.Entities;

namespace DeskBooking.Application.Mapper
{
    public class DomainToResponseProfile : Profile
    {
        public DomainToResponseProfile()
        {
            CreateMap<Workspace, WorkspaceResponse>();
        }

    }
}
