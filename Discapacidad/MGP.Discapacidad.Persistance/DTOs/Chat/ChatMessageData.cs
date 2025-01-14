using System;
namespace MGP.Discapacidad.Persistance.DTOs.Chat;
public class ChatMessageData
{
    public Guid TicketId { get; set; }
    public string AgentFullName { get; set; }
    public string Message { get; set; }
    public string UserEmail { get; set; }
    public DateTime SentAt { get; set; }

}
