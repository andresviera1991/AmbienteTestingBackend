using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace MGP.Backoffice.Persistance.Data.Seeds
{
    public class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            builder.HasData(
                new IdentityUserRole<Guid>
                {
                    UserId = Guid.Parse("ab76bc84-45e2-4ce5-bcc5-9d6a5aa4e21b"),
                    RoleId = Guid.Parse("00000000-0000-0000-0000-000000000001")
                },
                new IdentityUserRole<Guid>
                {
                    UserId = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187049"),
                    RoleId = Guid.Parse("00000000-0000-0000-0000-000000000003")
                },
                new IdentityUserRole<Guid>
                {
                    UserId = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187050"),
                    RoleId = Guid.Parse("00000000-0000-0000-0000-000000000002")
                },
                new IdentityUserRole<Guid>
                {
                    UserId = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187051"),
                    RoleId = Guid.Parse("00000000-0000-0000-0000-000000000002")
                }
            );
        }
    }
}