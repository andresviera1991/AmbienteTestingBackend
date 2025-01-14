using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MGP.Backoffice.Persistance.Data.Tables;

namespace MGP.Backoffice.Persistance.Data.Seeds
{
    public class TicketTypeSeed : IEntityTypeConfiguration<TicketType>
    {
        public void Configure(EntityTypeBuilder<TicketType> builder)
        {
            builder.HasData(
                new TicketType
                {
                    Id = 1,
                    Name = "CUD",
                    CreationDate = DateTime.UtcNow,
                    AreaId = 1
                },
                new TicketType
                {
                    Id = 2,
                    Name = "SUBE",
                    CreationDate = DateTime.UtcNow,
                    AreaId = 1
                },
                new TicketType
                {
                    Id = 3,
                    Name = "PARKING",
                    CreationDate = DateTime.UtcNow,
                    AreaId = 1
                }
            );
        }
    }
}
