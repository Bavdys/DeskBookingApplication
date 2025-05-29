using DeskBooking.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeskBooking.Infrastructure.Config
{
    public class BookingTypeConfig : IEntityTypeConfiguration<BookingType>
    {
        public void Configure(EntityTypeBuilder<BookingType> builder)
        {
            builder.ToTable("BookingType");

            builder.Property(x => x.Name).HasMaxLength(64).IsRequired();

            builder.HasData
                    (
                        new BookingType
                        {
                            Id = 1,
                            Name = "Room"
                        },
                        new BookingType
                        {
                            Id = 2,
                            Name = "Desk"
                        }
                    );
        }
    }
}
