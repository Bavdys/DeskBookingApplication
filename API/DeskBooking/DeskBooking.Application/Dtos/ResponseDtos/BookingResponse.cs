using System;

namespace DeskBooking.Application.Dtos.ResponseDtos
{
    public class BookingResponse
    {
        public Guid Id { get; set; }
        public string WorkspaceType { get; set; }
        public string PictureUrl { get; set; }
        public int Amount { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
