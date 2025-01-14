using AutoMapper;
using MediatR;
using MGP.Discapacidad.API.Controllers.V1.Chat.Request;
using MGP.Discapacidad.Application.UseCase.V1.Chat.AddMessage;
using MGP.Discapacidad.Application.UseCase.V1.Chat.VerifyTicket;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;
namespace MGP.Discapacidad.API.Hubs;

public class TicketChatHub : Hub
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    public TicketChatHub(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    public async Task SendMessage(SendMessageRequestModel request)
    {
        try
        {
            var sendAt = DateTime.UtcNow;
            await Clients.Group(request.TicketId.ToString()).SendAsync("NewMessage", request.AgentFullName, request.Message, sendAt.ToString());
            var addMesageRequest = _mapper.Map<AddMessageRequest>(request);
            addMesageRequest.SentAt = sendAt.AddHours(-3);
            await _mediator.Send(addMesageRequest);
        }
        catch (Exception)
        {
            await Clients.Group(request.TicketId.ToString()).SendAsync("NewMessage", "HA OCURRIDO UN ERROR AL ENVIAR EL MENSAJE");
        }
    }

    public async Task JoinTicketChat(Guid ticketId)
    {
        var ticketIdExists = await _mediator.Send(new TicketExistRequest() { TicketId = ticketId }); 

        if (!ticketIdExists)
        {
            throw new HubException("Ticket inexistente");
        }
        await Groups.AddToGroupAsync(Context.ConnectionId, ticketId.ToString());
    }

    public async Task LeaveTramite(Guid ticketId)
    {
        var ticketIdExists = await _mediator.Send(new TicketExistRequest() { TicketId = ticketId });

        if (!ticketIdExists)
        {
            throw new HubException("Ticket inexistente");
        }
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, ticketId.ToString());
    }
}
