using DeskBooking.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeskBooking.Infrastructure.Config
{
    public class WorkspaceConfig : IEntityTypeConfiguration<Workspace>
    {
        public void Configure(EntityTypeBuilder<Workspace> builder)
        {
            builder.ToTable("Workspace");

            builder.Property(x => x.Type).HasMaxLength(64).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(1024).IsRequired();
            builder.Property(x => x.IsAirConditioner).IsRequired();
            builder.Property(x => x.IsGameRoom).IsRequired();
            builder.Property(x => x.IsWiFi).IsRequired();
            builder.Property(x => x.IsCoffee).IsRequired();
            builder.Property(x => x.IsMicrophones).IsRequired();
            builder.Property(x => x.IsHeadphones).IsRequired();

            builder.HasOne(x => x.PlaceType).WithMany(x => x.Workspaces).HasForeignKey(x => x.PlaceTypeId);
        }
    }
}
