using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MGP.Backoffice.Persistence.Data.Tables;

namespace MGP.Backoffice.Persistence.Data.Seeds
{
    public class RoleSeed : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                new Role
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    Name = "ADMIN",
                    NormalizedName = "ADMIN".ToUpper(),
                    CreationDate = DateTime.UtcNow
                }
                ,
                new Role
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    Name = "AGENTE",
                    NormalizedName = "AGENTE".ToUpper(),
                    CreationDate = DateTime.UtcNow
                },
                new Role
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    Name = "SUPERVISOR",
                    NormalizedName = "SUPERVISOR".ToUpper(),
                    CreationDate = DateTime.UtcNow
                }
            );
        }
    }
}
