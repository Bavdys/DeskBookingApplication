using AutoMapper;
using DeskBooking.Application.Dtos.ResponseDtos;
using DeskBooking.Domain.Entities;
using System.Linq;

namespace DeskBooking.Application.Mapper
{
    public class DomainToResponseProfile : Profile
    {
        public DomainToResponseProfile()
        {
            CreateMap<Workspace, WorkspaceResponse>().
                ForMember(x => x.PlaceType, i => i.MapFrom(s => s.PlaceType.Type)).
                ForMember(x => x.PictureURLs, i => i.MapFrom(s => s.Pictures.Select(g => g.URL).ToList())).
                ForMember(x => x.Capacities, i => i.MapFrom(s => s.Capacities.ToDictionary(h => h.Amount, g => g.Availability)));

            CreateMap<Booking, BookingResponse>().
                ForMember(x => x.WorkspaceType, i => i.MapFrom(s => s.Workspace.Type)).
                ForMember(x => x.PictureUrl, i => i.MapFrom(s => s.Workspace.Pictures.FirstOrDefault().URL)).
                ForMember(x => x.Amount, i => i.MapFrom(s => s.Capacity.Amount));
        }
    }
}
