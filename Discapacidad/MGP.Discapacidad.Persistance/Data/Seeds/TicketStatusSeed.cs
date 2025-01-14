using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MGP.Discapacidad.Persistance.Data.Tables;
using System;
namespace MGP.Discapacidad.Persistance.Data.Seeds;
public class TicketStatusSeed : IEntityTypeConfiguration<TicketStatus>
{
    public void Configure(EntityTypeBuilder<TicketStatus> builder)
    {
        builder.HasData(
            new TicketStatus
            {
                Id = 1,
                Name = "Nuevo",
                CreationDate = DateTime.UtcNow
            },
            new TicketStatus
            {
                Id = 2,
                Name = "En Proceso - Vecino",
                CreationDate = DateTime.UtcNow
            },
            new TicketStatus
            {
                Id = 3,
                Name = "En Proceso - Agente",
                CreationDate = DateTime.UtcNow
            },
            new TicketStatus
            {
                Id = 4,
                Name = "Esperando Resolución",
                CreationDate = DateTime.UtcNow
            }, 
            new TicketStatus
            {
                Id = 5,
                Name = "Cerrado por falta de Respuesta",
                CreationDate = DateTime.UtcNow
            },
            new TicketStatus
            {
                Id = 6,
                Name = "Cerrado Otorgado",
                CreationDate = DateTime.UtcNow
            }, 
            new TicketStatus
            {
                Id = 7,
                Name = "Cerrado denegado",
                CreationDate = DateTime.UtcNow
            },
            new TicketStatus
            {
                Id = 8,
                Name = "Cancelado",
                CreationDate = DateTime.UtcNow
            }
        );
    }
}