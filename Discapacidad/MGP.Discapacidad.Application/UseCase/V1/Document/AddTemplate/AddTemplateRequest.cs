using Flunt.Notifications;
using MediatR;
using MGP.Discapacidad.CrossCutting.ResponseData;
namespace MGP.Discapacidad.Application.UseCase.V1.Document.AddTemplate;
public class AddTemplateRequest : Notifiable, IRequest<ResponseData<AddTemplateResponse, ResponseMessage>>
{
    public int TicketTypeId { get; set; }
    public string DocumentPDF { get; set; }
    public string Name { get; set; }
    public string Information { get; set; }
}
