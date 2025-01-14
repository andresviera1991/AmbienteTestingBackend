using MGP.Backoffice.Persistance.Data.Tables;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MGP.Backoffice.Persistance.Data.Seeds
{
    public class AgentTicketTypeSeed : IEntityTypeConfiguration<AgentTicketType>
    {
        public void Configure(EntityTypeBuilder<AgentTicketType> builder)
        {
            builder.HasData(
                new AgentTicketType
                {
                    Id = Guid.Parse("ab76bc84-45e2-4ce5-bcc5-9d6a5aa4e17a"),
                    AgentId = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187050"),
                    TicketTypeId = 1,
                    CreationDate = DateTime.UtcNow
                },
                new AgentTicketType
                {
                    Id = Guid.Parse("ab76bc84-45e2-4ce5-bcc5-9d6a5aa4e17b"),
                    AgentId = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187050"),
                    TicketTypeId = 2,
                    CreationDate = DateTime.UtcNow
                },
                new AgentTicketType
                {
                    Id = Guid.Parse("ab76bc84-45e2-4ce5-bcc5-9d6a5aa4e17c"),
                    AgentId = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187051"),
                    TicketTypeId = 1,
                    CreationDate = DateTime.UtcNow
                },
                new AgentTicketType
                {
                    Id = Guid.Parse("ab76bc84-45e2-4ce5-bcc5-9d6a5aa4e17d"),
                    AgentId = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187051"),
                    TicketTypeId = 2,
                    CreationDate = DateTime.UtcNow
                },
                new AgentTicketType
                {
                    Id = Guid.Parse("ab76bc84-45e2-4ce5-bcc5-9d6a5aa4e17e"),
                    AgentId = Guid.Parse("18d14490-91c1-4ba6-843c-9b501d187051"),
                    TicketTypeId = 3,
                    CreationDate = DateTime.UtcNow
                }
            );
        }
    }
}
