using AutoMapper;
using System.Threading.Tasks;
using MGP.Discapacidad.Domain.Interfaces;
using MGP.Discapacidad.Persistance.Data.Tables;
using MGP.Discapacidad.Persistance.DTOs.Chat;
using MGP.Discapacidad.Persistance.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.CrossCutting.Enum;
namespace MGP.Discapacidad.Domain.Services;

public class ChatService : IChatService
{
    private readonly IMapper _mapper;
    private readonly IChatRepository _chatRepository;
    private readonly IEmailService _emailService;

    public ChatService(IMapper mapper,
                       IChatRepository chatRepository,
                       IEmailService emailService)
    {
        _mapper = mapper;
        _chatRepository = chatRepository;
        _emailService = emailService;
    }
    public async Task AddMessageAsync(ChatMessageData addMessageData)
    {
        var ticket = await _chatRepository.AddMessageAsync(_mapper.Map<ChatMessage>(addMessageData));

        if (!string.IsNullOrEmpty(addMessageData.AgentFullName))
        {
            var bodyEmail = await _emailService.GetEmailTemplateAsync(EmailTemplateEnum.NEW_TICKET_ACTIVITY);

            await _emailService.SendEmailHandlerAsync(addMessageData.UserEmail,
                                                      $"Novedades en tu ticket ({ticket.TicketCode})",
                                                      bodyEmail);
        }
    }

    public async Task<List<GetMessageData>> GetMessagesAsync(Guid ticketId)
    {
        var messages = await _chatRepository.GetMessagesByTicketIdAsync(ticketId);

        var listMessageData = messages.Select(m => new GetMessageData
        {
            AgentFullName = m.AgentFullName,
            Message = m.Message,
            SentAt = m.SentAt.ToLocalTime().ToString("dd/MM/yyyy HH:mm:ss")
        }).ToList();

        return listMessageData;
    }
}
