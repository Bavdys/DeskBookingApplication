using AutoMapper;
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
    public class WorkspaceApplicationService : IWorkspaceApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public WorkspaceApplicationService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<WorkspaceResponse>> GetAllWorkspaces()
        {
            var spec = new WorkspaceWithBokingTypeAndCapacityAndBookingAndPictureSpecification();
            var workspaces = await _unitOfWork.Repository<Workspace,Guid>().GetAsync(spec);
            var workspacesResponse = _mapper.Map<IReadOnlyList<Workspace>, IReadOnlyList<WorkspaceResponse>>(workspaces);
            
            return workspacesResponse;
        }
    }
}
