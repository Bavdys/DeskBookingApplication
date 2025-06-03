using DeskBooking.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeskBooking.Infrastructure.Config
{
    public class PlaceTypeConfig : IEntityTypeConfiguration<PlaceType>
    {
        public void Configure(EntityTypeBuilder<PlaceType> builder)
        {
            builder.ToTable("PlaceType");

            builder.Property(x => x.Type).HasMaxLength(64).IsRequired();

            builder.HasData
                    (
                        new PlaceType
                        {
                            Id = 1,
                            Type = "Room"
                        },
                        new PlaceType
                        {
                            Id = 2,
                            Type = "Desk"
                        }
                    );
        }
    }
}
