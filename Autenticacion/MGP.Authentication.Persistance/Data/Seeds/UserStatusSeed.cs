using MGP.Authentication.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;

namespace MGP.Authentication.Persistance.Data.Seeds
{
    public class UserStatusSeed : IEntityTypeConfiguration<UserStatus>
    {
        public void Configure(EntityTypeBuilder<UserStatus> builder)
        {
            builder.HasData(
                new UserStatus
                {
                    Id = 1,
                    Description = "Activo",
                    CreationDate = DateTime.UtcNow
                },
                new UserStatus
                {
                    Id = 2,
                    Description = "Inactivo",
                    CreationDate = DateTime.UtcNow
                },
                new UserStatus
                {
                    Id = 3,
                    Description = "Bloqueado",
                    CreationDate = DateTime.UtcNow
                },
                new UserStatus
                {
                    Id = 4,
                    Description = "Eliminado",
                    CreationDate = DateTime.UtcNow
                }
            );
        }
    }
}
