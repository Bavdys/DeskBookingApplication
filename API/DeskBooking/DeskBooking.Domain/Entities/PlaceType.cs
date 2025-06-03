using DeskBooking.Domain.Core.Models;
using System.Collections.Generic;

namespace DeskBooking.Domain.Entities
{
    public class PlaceType : BaseEntity<int>
    {
        public string Type { get; set; }

        public ICollection<Workspace> Workspaces { get; set; }
    }
}