using DeskBooking.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DeskBooking.API.Extensions
{
    internal static class ServiceCollectionExtension
    {
        internal static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                 x => x.MigrationsAssembly("DeskBooking.Infrastructure")));
            return services;
        }
    }
}
