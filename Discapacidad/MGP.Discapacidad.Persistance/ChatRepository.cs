using MGP.Discapacidad.CrossCutting.Enum;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.Persistance.Data.Tables;
using MGP.Discapacidad.Persistance.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Persistance;

public class ChatRepository : IChatRepository
{
    private readonly MyDbContext _dbContext;

    public ChatRepository(MyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Ticket> AddMessageAsync(ChatMessage message)
    {
        var ticket = await _dbContext.Set<Ticket>().Where(t => t.Id == message.TicketId).SingleOrDefaultAsync() ?? throw new TicketNotFoundException();

        message.Id = Guid.NewGuid();

        await _dbContext.Set<ChatMessage>().AddAsync(message);

        if (string.IsNullOrEmpty(message.AgentFullName))
        {
            ticket.TicketStatusId = (int)TicketStatusEnum.IN_PROCESS_AGENT;
        }
        else
        {
            ticket.TicketStatusId = (int)TicketStatusEnum.IN_PROCESS_NEIGHBOR;
        }
        await _dbContext.SaveChangesAsync();
        return ticket;
    }

    public async Task<List<ChatMessage>> GetMessagesByTicketIdAsync(Guid ticketId)
    {
        var messages = await _dbContext.Set<ChatMessage>().Where(m => m.TicketId == ticketId).OrderBy(d => d.SentAt).ToListAsync();

        return messages;
    }
}
