using Autofac;
using DeskBooking.Application.Interfaces;
using DeskBooking.Application.Services;

namespace DeskBooking.Application
{
    public class ApplicationAutoFacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType(typeof(WorkspaceApplicationService)).As(typeof(IWorkspaceApplicationService));
            builder.RegisterType(typeof(BookingApplicationService)).As(typeof(IBookingApplicationService));
        }
    }
}
