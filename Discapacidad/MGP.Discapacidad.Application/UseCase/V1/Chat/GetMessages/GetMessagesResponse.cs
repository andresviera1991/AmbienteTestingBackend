using MGP.Discapacidad.Persistance.DTOs.Chat;
using System.Collections.Generic;
namespace MGP.Discapacidad.Application.UseCase.V1.Chat.GetMessages;

public class GetMessagesResponse
{
    public List<GetMessageData> GetMessageData { get; set; }
}
