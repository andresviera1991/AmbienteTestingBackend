using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MGP.Backoffice.Persistance.Data.Tables;
namespace MGP.Backoffice.Persistance.Data.Seeds;

public class UserStatusSeed : IEntityTypeConfiguration<UserStatus>
{
    public void Configure(EntityTypeBuilder<UserStatus> builder)
    {
        builder.HasData(
            new UserStatus
            {
                Id = 1,
                Name = "ACTIVO",
                CreationDate = DateTime.UtcNow
            },
            new UserStatus
            {
                Id = 2,
                Name = "INACTIVO",
                CreationDate = DateTime.UtcNow
            },
            new UserStatus
            {
                Id = 3,
                Name = "BLOQUEADO",
                CreationDate = DateTime.UtcNow
            },
            new UserStatus
            {
                Id = 4,
                Name = "ELIMINADO",
                CreationDate = DateTime.UtcNow
            },
            new UserStatus
            {
                Id = 5,
                Name = "SOLICITA BLANQUEO DE CONTRASEÑA",
                CreationDate = DateTime.UtcNow
            },
            new UserStatus
            {
                Id = 6,
                Name = "SOLICITA ACCESO A CUENTA",
                CreationDate = DateTime.UtcNow
            }
        );
    }
}
