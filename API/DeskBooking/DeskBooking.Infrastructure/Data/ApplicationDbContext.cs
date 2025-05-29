using DeskBooking.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DeskBooking.Infrastructure.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingType> BookingTypes { get; set; }
        public DbSet<Capacity> Capacities { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Workspace> Workspaces { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
