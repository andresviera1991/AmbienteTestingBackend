using System;
namespace MGP.Discapacidad.API.Controllers.V1.Chat.Request;

public class SendMessageRequestModel
{
    public Guid TicketId { get; set; }
    public string AgentFullName { get; set; } 
    public string Message { get; set; }
    public string UserEmail { get; set; }
}
