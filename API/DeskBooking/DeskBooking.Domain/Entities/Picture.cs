using DeskBooking.Domain.Core.Models;
using System;

namespace DeskBooking.Domain.Entities
{
    public class Picture : BaseEntity<Guid>
    {
        public string URL { get; set; }

        public int WorkspaceId { get; set; }
        public Workspace Workspace { get; set; }
    }
}
