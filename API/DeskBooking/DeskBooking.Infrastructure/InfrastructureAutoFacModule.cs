using Autofac;
using DeskBooking.Domain.Core.Interfaces;
using DeskBooking.Infrastructure.Core.Repositories;

namespace DeskBooking.Infrastructure
{
    public class InfrastructureAutoFacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<,>)).As(typeof(IGenericRepository<,>));
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork));
        }
    }
}
