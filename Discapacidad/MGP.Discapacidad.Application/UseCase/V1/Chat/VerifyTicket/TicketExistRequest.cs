using MediatR;
using System;
namespace MGP.Discapacidad.Application.UseCase.V1.Chat.VerifyTicket;
public class TicketExistRequest : IRequest<bool>
{
    public Guid TicketId { get; set; }
}
