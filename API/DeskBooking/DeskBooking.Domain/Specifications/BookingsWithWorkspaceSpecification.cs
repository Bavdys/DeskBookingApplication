using DeskBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskBooking.Domain.Specifications
{
    public class BookingsWithWorkspaceSpecification : BaseSpecification<Booking>
    {
        public BookingsWithWorkspaceSpecification() 
        {
            AddInclude(x => x.Workspace);
        }
        public BookingsWithWorkspaceSpecification(Guid id) : base(x => x.Id == id)
        {
            AddInclude(x => x.Workspace);
        }
    }
}
