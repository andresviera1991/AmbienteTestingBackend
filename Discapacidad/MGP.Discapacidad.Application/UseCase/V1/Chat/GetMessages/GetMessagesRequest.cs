using Flunt.Notifications;
using MediatR;
using MGP.Discapacidad.CrossCutting.ResponseData;
using System;
namespace MGP.Discapacidad.Application.UseCase.V1.Chat.GetMessages;

public class GetMessagesRequest : Notifiable, IRequest<ResponseData<GetMessagesResponse,ResponseMessage>>
{
    public Guid TicketId { get; set; }
}
