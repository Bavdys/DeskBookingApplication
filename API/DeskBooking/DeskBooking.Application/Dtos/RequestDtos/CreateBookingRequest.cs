using System;

namespace DeskBooking.Application.Dtos.RequestDtos
{
    public class CreateBookingRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public Guid WorkspaceId { get; set; }
        public Guid CapacityId { get; set; }
    }
}
