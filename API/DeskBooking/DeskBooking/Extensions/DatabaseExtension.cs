using DeskBooking.Infrastructure.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace DeskBooking.API.Extensions
{
    internal static class DatabaseExtension
    {
        internal static IWebHost MigrateAndSeedDatabase(this IWebHost webHost)
        {
            using (var scope = webHost.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                using (var context = services
                .GetRequiredService<ApplicationDbContext>())
                {
                    try
                    {
                        context.Database.Migrate();
                        ApplicationDbContextSeed.Seed(context);
                    }
                    catch (Exception ex)
                    {
                        var logger = services
                        .GetRequiredService<ILogger<Program>>();
                        logger.LogError(ex,
                        "An error occurred while migrating or seeding the database.");
                        throw;
                    }
                }
            }
            return webHost;
        }
    }
}
