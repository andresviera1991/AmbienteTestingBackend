using Flunt.Notifications;
using MediatR;
using MGP.Discapacidad.CrossCutting.ResponseData;
using System;
namespace MGP.Discapacidad.Application.UseCase.V1.Chat.AddMessage;

public class AddMessageRequest : Notifiable, IRequest<ResponseData<AddMessageResponse, ResponseMessage>>
{
    public Guid TicketId { get; set; }
    public string AgentFullName { get; set; }
    public string Message { get; set; }
    public string UserEmail { get; set; }
    public DateTime SentAt { get; set; }
}
