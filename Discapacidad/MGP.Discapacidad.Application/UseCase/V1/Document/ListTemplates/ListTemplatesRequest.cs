using Flunt.Notifications;
using MediatR;
using MGP.Discapacidad.CrossCutting.ResponseData;
namespace MGP.Discapacidad.Application.UseCase.V1.Document.ListTemplates;
public class ListTemplatesRequest : Notifiable, IRequest<ResponseData<ListTemplatesResponse, ResponseMessage>>
{
    public int? TicketTypeId { get; set; }
}
