using MGP.Authentication.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MGP.Authentication.Persistance.Data.Configuration
{
    public class PhoneNumberConfig : IEntityTypeConfiguration<PhoneNumber>
    {
        public void Configure(EntityTypeBuilder<PhoneNumber> builder)
        {
            builder.Property(e => e.CreationDate).HasColumnType("timestamp with time zone").HasPrecision(0);
            builder.Property(e => e.ModifiedDate).HasColumnType("timestamp with time zone").HasPrecision(0);

        }
    }
}
