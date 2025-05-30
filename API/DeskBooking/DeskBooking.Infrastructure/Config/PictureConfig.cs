using DeskBooking.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeskBooking.Infrastructure.Config
{
    public class PictureConfig : IEntityTypeConfiguration<Picture>
    {
        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            builder.ToTable("Picture");

            builder.Property(x => x.URL).IsRequired();

            builder.HasOne(x => x.Workspace).WithMany(x => x.Pictures).HasForeignKey(x => x.WorkspaceId);
        }
    }
}
