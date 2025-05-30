using DeskBooking.Domain.Core.Models;
using System.Collections.Generic;

namespace DeskBooking.Domain.Entities
{
    public class BookingType : BaseEntity<int>
    {
        public string Name { get; set; }

        public ICollection<Workspace> Workspaces { get; }
    }
}