using Flunt.Notifications;
using MediatR;
using MGP.Backoffice.CrossCutting.ResponseData;
namespace MGP.Backoffice.Application.UseCase.V1.Catalog.GetTicketByArea;
public class GetTicketByAreaRequest : Notifiable, IRequest<ResponseData<GetTicketByAreaResponse,ResponseMessage>>
{
    public string Area { get; set; }
}
