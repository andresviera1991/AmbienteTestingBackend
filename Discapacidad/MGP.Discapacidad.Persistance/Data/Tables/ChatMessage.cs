using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGP.Discapacidad.Persistance.Data.Tables;

[Table("ChatMessage")]
public class ChatMessage
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public Guid TicketId { get; set; }

    public string AgentFullName { get; set; }

    [Required]
    [MaxLength(1000)]
    public string Message { get; set; }

    [Required]
    public DateTime SentAt { get; set; }
}
