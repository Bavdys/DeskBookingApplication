using DeskBooking.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeskBooking.Infrastructure.Config
{
    public class WorkspaceCapacityConfig : IEntityTypeConfiguration<WorkspaceCapacity>
    {
        public void Configure(EntityTypeBuilder<WorkspaceCapacity> builder)
        {
            builder.ToTable("WorkspaceCapacity");

            builder.HasKey(x => new { x.WorkspaceId, x.CapacityId });
            
            builder.Property(x => x.Availability).IsRequired();

            builder.HasOne(x => x.Workspace).WithMany(x => x.CapacityLink).HasForeignKey(x => x.WorkspaceId);
            builder.HasOne(x => x.Capacity).WithMany(x => x.WorkspaceLink).HasForeignKey(x => x.CapacityId);
        }
    }
}
