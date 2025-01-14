using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MGP.Backoffice.Persistance.Data.Tables;

namespace MGP.Backoffice.Persistance.Data.Seeds
{
    public class AreaSeed : IEntityTypeConfiguration<Area>
    {
        public void Configure(EntityTypeBuilder<Area> builder)
        {
            builder.HasData(
                new Area
                {
                    Id = 1,
                    Name = "DISCAPACIDAD",
                    CreationDate = DateTime.UtcNow
                }
            );
        }
    }
}
