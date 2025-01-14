using MGP.Authentication.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace MGP.Authentication.Persistance.Data.Seeds
{
    internal class LevelUserSeed : IEntityTypeConfiguration<UserLevel>
    {
        public void Configure(EntityTypeBuilder<UserLevel> builder)
        {
            builder.HasData(
                new UserLevel
                {
                    Id = 1,
                    Description = "Nivel 0",
                    CreationDate = DateTime.UtcNow
                },
                new UserLevel
                {
                    Id = 2,
                    Description = "Nivel 1",
                    CreationDate = DateTime.UtcNow
                },
                new UserLevel
                {
                    Id = 3,
                    Description = "Nivel 2",
                    CreationDate = DateTime.UtcNow
                }
            );
        }
        }
}
