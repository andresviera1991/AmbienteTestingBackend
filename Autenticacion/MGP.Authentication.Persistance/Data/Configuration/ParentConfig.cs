using MGP.Authentication.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MGP.Authentication.Persistance.Data.Configurations
{
    public class ParentConfig : IEntityTypeConfiguration<Parent>
    {
        public void Configure(EntityTypeBuilder<Parent> builder)
        {
            builder.Property(e => e.CreationDate).HasColumnType("timestamp with time zone").HasPrecision(0);
            builder.Property(e => e.ModifiedDate).HasColumnType("timestamp with time zone").HasPrecision(0);
        }
    }
}
