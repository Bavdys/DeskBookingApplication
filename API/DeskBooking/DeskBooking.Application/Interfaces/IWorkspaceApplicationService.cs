using DeskBooking.Application.Dtos.ResponseDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeskBooking.Application.Interfaces
{
    public interface IWorkspaceApplicationService
    {
        public Task<IEnumerable<WorkspaceResponse>> GetAllWorkspaces();
    }
}
