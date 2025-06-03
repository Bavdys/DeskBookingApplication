using DeskBooking.Domain.Core.Models;
using System;

namespace DeskBooking.Domain.Entities
{
    public class Booking : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public Guid WorkspaceId { get; set; }
        public Workspace Workspace { get; set; }

        public Guid CapacityId { get; set; }
        public Capacity Capacity { get; set; }
    }
}
