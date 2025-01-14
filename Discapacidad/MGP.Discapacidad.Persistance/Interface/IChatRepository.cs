using MGP.Discapacidad.Persistance.Data.Tables;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MGP.Discapacidad.Persistance.Interface;

public interface IChatRepository
{
    Task<Ticket> AddMessageAsync(ChatMessage message);
    Task<List<ChatMessage>> GetMessagesByTicketIdAsync(Guid ticketId);
}
