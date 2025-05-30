using DeskBooking.Domain.Entities;
using DeskBooking.Domain.Interfaces;
using DeskBooking.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeskBooking.Infrastructure.Repositories
{
    public class WorkspaceRepository : IWorkspaceRepository
    {
        private readonly ApplicationDbContext _context;

        public WorkspaceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<Workspace>> GetWorkspacesAsync()
        {
            return await _context.Workspaces.
                Include(w => w.BookingType).
                Include(w => w.CapacityLink).ThenInclude(w => w.Capacity).
                Include(w => w.Bookings).
                Include(w => w.Pictures).
                ToListAsync();
        }
    }
}
