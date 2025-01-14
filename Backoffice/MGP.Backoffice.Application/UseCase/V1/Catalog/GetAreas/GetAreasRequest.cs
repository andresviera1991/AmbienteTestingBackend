using Flunt.Notifications;
using MediatR;
using MGP.Backoffice.CrossCutting.ResponseData;
namespace MGP.Backoffice.Application.UseCase.V1.Catalog.GetAreas;
public class GetAreasRequest : Notifiable, IRequest<ResponseData<GetAreasResponse,ResponseMessage>>
{
}
