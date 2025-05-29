using DeskBooking.Domain.Core.Models;
using System;
using System.Collections.Generic;

namespace DeskBooking.Domain.Entities
{
    public class Workspace : BaseEntity<Guid>
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public bool IsAirConditioner { get; set; }
        public bool IsGameRoom { get; set; }
        public bool IsWiFi { get; set; }
        public bool IsCoffee { get; set; }
        public bool IsMicrophones { get; set; }
        public bool IsHeadphones { get; set; }

        public int BookingTypeId { get; set; }
        public BookingType BookingType { get; set; }

        public ICollection<Picture> Pictures { get; set; }
        public ICollection<WorkspaceCapacity> CapacityLink { get; set; }
    }
}
