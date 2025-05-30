using DeskBooking.Domain.Entities;
using DeskBooking.Domain.Interfaces;
using DeskBooking.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeskBooking.Infrastructure.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly ApplicationDbContext _context;

        public BookingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Booking> GetBookingByIdAsync(Guid id)
        {
            return await _context.Bookings.
                Include(b => b.Workspace).
                FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<IReadOnlyList<Booking>> GetBookingsAsync()
        {
            return await _context.Bookings.
                Include(b => b.Workspace).
                ToListAsync();
        }
    }
}
