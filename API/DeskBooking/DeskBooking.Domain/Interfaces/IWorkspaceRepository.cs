using DeskBooking.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeskBooking.Domain.Interfaces
{
    public interface IWorkspaceRepository
    {
        Task<IReadOnlyList<Workspace>> GetWorkspacesAsync();
    }
}
