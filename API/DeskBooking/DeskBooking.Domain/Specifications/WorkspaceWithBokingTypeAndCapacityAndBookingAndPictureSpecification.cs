using DeskBooking.Domain.Entities;

namespace DeskBooking.Domain.Specifications
{
    public class WorkspaceWithBokingTypeAndCapacityAndBookingAndPictureSpecification : BaseSpecification<Workspace>
    {
        public WorkspaceWithBokingTypeAndCapacityAndBookingAndPictureSpecification()
        {
            AddInclude(x => x.BookingType);
            AddInclude(x => x.Bookings);
            AddInclude(x => x.Pictures);
            AddInclude("CapacityLink.Capacity");
        }
    }
}
