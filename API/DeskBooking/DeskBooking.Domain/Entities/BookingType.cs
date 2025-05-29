using DeskBooking.Domain.Core.Models;

namespace DeskBooking.Domain.Entities
{
    public class BookingType : BaseEntity<int>
    {
        public string Name { get; set; }
    }
}