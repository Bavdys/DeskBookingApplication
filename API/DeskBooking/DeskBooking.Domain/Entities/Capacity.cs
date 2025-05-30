using DeskBooking.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace DeskBooking.Domain.Entities
{
    public class Capacity : BaseEntity<Guid>
    {
        public int Count { get; set; }

        public ICollection<WorkspaceCapacity> WorkspaceLink { get; }
    }
}
