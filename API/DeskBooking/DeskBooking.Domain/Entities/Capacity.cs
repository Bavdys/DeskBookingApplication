using DeskBooking.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace DeskBooking.Domain.Entities
{
    public class Capacity : BaseEntity<Guid>
    {
        public int Amount { get; set; }
        public int Availability { get; set; }

        public Guid WorkspaceId { get; set; }
        public Workspace Workspace { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
