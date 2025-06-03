using DeskBooking.Domain.Entities;

namespace DeskBooking.Domain.Specifications
{
    public class WorkspaceWithBokingTypeAndCapacityAndBookingAndPictureSpecification : BaseSpecification<Workspace>
    {
        public WorkspaceWithBokingTypeAndCapacityAndBookingAndPictureSpecification()
        {
            AddInclude(x => x.PlaceType);
            AddInclude(x => x.Bookings);
            AddInclude(x => x.Pictures);
            AddInclude(x => x.Capacities);
        }
    }
}
