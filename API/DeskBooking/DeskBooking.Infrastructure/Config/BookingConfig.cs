using DeskBooking.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeskBooking.Infrastructure.Config
{
    public class BookingConfig : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.ToTable("Booking");

            builder.Property(x => x.Name).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(128).IsRequired();
            builder.Property(x => x.DateFrom).IsRequired();
            builder.Property(x => x.DateTo).IsRequired();

            builder.HasOne(x => x.Workspace).WithMany().HasForeignKey(x => x.WorkspaceId);
        }
    }
}
