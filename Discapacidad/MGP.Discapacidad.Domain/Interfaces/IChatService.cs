using MGP.Discapacidad.Persistance.DTOs.Chat;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Domain.Interfaces;

public interface IChatService
{
    Task AddMessageAsync(ChatMessageData addMessageData);
    Task<List<GetMessageData>> GetMessagesAsync(Guid ticketId);
}
