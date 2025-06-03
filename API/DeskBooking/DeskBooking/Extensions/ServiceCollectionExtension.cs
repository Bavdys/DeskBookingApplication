using Autofac;
using Autofac.Extensions.DependencyInjection;
using DeskBooking.Application;
using DeskBooking.Application.Mapper;
using DeskBooking.Infrastructure;
using DeskBooking.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

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

        internal static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(AutoMapperConfig.RegisterMappings());

            return services;
        }

        internal static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c => c.SwaggerDoc("v1", new OpenApiInfo { Title = "DeskBooking", Version = "v1" }));

            return services;
        }

        internal static AutofacServiceProvider AddAutofac(this IServiceCollection services)
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule<InfrastructureAutoFacModule>();
            containerBuilder.RegisterModule<ApplicationAutoFacModule>();
            containerBuilder.Populate(services);
            var container = containerBuilder.Build();
            return new AutofacServiceProvider(container);
        }
    }
}
