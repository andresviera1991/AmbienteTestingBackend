using MGP.Discapacidad.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
namespace MGP.Discapacidad.Persistance.Data.Seeds;
public class DocumentStatusSeed : IEntityTypeConfiguration<DocumentStatus>
{
    public void Configure(EntityTypeBuilder<DocumentStatus> builder)
    {
        builder.HasData(
            new DocumentStatus
            {
                Id = 1,
                Name = "En espera de validación",
                CreationDate = DateTime.UtcNow

            },
            new DocumentStatus
            {
                Id = 2,
                Name = "Valido",
                CreationDate = DateTime.UtcNow

            },
            new DocumentStatus
            {
                Id = 3,
                Name = "Invalido",
                CreationDate = DateTime.UtcNow

            },
             new DocumentStatus
             {
                 Id = 4,
                 Name = "Eliminado",
                 CreationDate = DateTime.UtcNow

             }
        );

    }

}
