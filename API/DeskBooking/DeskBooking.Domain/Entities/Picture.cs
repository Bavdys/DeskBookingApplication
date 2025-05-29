using DeskBooking.Domain.Core.Models;
using System;

namespace DeskBooking.Domain.Entities
{
    public class Picture : BaseEntity<Guid>
    {
        public string URL { get; set; }

        public Guid WorkspaceId { get; set; }
        public Workspace Workspace { get; set; }
    }
}
