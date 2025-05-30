using DeskBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeskBooking.Domain.Interfaces
{
    public interface IBookingRepository
    {
        Task<IReadOnlyList<Booking>> GetBookingsAsync();
        Task<Booking> GetBookingByIdAsync(Guid id);
    }
}
