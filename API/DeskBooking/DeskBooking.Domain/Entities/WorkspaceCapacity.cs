using System;

namespace DeskBooking.Domain.Entities
{
    public class WorkspaceCapacity
    {
        public int Availability { get; set; }

        public Guid WorkspaceId { get; set; }
        public Guid CapacityId { get; set; }

        public Workspace Workspace { get; set; }
        public Capacity Capacity { get; set; }
    }
}