using DeskBooking.Domain.Entities;
using System;

namespace DeskBooking.Domain.Specifications
{
    public class BookingsWithWorkspaceSpecification : BaseSpecification<Booking>
    {
        public BookingsWithWorkspaceSpecification() 
        {
            AddInclude(x => x.Workspace);
            AddInclude("Workspace.Pictures");
            AddInclude(x => x.Capacity);
        }
        public BookingsWithWorkspaceSpecification(Guid id) : base(x => x.Id == id)
        {
            AddInclude(x => x.Workspace);
            AddInclude("Workspace.Pictures");
            AddInclude(x => x.Capacity);
        }
    }
}
