using DeskBooking.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeskBooking.Infrastructure.Config
{
    public class CapacityConfig : IEntityTypeConfiguration<Capacity>
    {
        public void Configure(EntityTypeBuilder<Capacity> builder)
        {
            builder.ToTable("Capacity");

            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x => x.Availability).IsRequired();

            builder.HasOne(x => x.Workspace).WithMany(x => x.Capacities).HasForeignKey(x => x.WorkspaceId);
        }
    }
}
