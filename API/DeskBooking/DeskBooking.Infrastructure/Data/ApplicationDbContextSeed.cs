using DeskBooking.Domain.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace DeskBooking.Infrastructure.Data
{
    public class ApplicationDbContextSeed
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.Capacities.Any())
            {
                var capacitiesData = File.ReadAllText("../DeskBooking.Infrastructure/SeedData/Capacities.json");
                var capacities = JsonSerializer.Deserialize<List<Capacity>>(capacitiesData);
                context.Capacities.AddRange(capacities);
            }
            if (!context.Workspaces.Any())
            {
                var workspacesData = File.ReadAllText("../DeskBooking.Infrastructure/SeedData/Workspaces.json");
                var workspaces = JsonSerializer.Deserialize<List<Workspace>>(workspacesData);
                context.Workspaces.AddRange(workspaces);
            }
            if (!context.WorkspaceCapasities.Any())
            {
                var workspaceCapacitiesData = File.ReadAllText("../DeskBooking.Infrastructure/SeedData/WorkspaceCapacities.json");
                var workspaceCapacities = JsonSerializer.Deserialize<List<WorkspaceCapacity>>(workspaceCapacitiesData);
                context.WorkspaceCapasities.AddRange(workspaceCapacities);
            }
            if (!context.Pictures.Any())
            {
                var picturesData = File.ReadAllText("../DeskBooking.Infrastructure/SeedData/Pictures.json");
                var pictures = JsonSerializer.Deserialize<List<Picture>>(picturesData);
                context.Pictures.AddRange(pictures);
            }
            //if (!context.Bookings.Any())
            //{
            //    var bookingsData = File.ReadAllText("../DeskBooking.Infrastructure/SeedData/Bookings.json"); ///// Add Data Later
            //    var bookings = JsonSerializer.Deserialize<List<Booking>>(bookingsData);
            //    context.Bookings.AddRange(bookings);
            //}

            if (context.ChangeTracker.HasChanges())
            {
                context.SaveChanges();
            }
        }
    }
}
