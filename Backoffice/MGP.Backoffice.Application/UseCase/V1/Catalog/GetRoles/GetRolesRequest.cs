using Flunt.Notifications;
using MediatR;
using MGP.Backoffice.CrossCutting.ResponseData;
namespace MGP.Backoffice.Application.UseCase.V1.Catalog.GetRoles;
public class GetRolesRequest : Notifiable, IRequest<ResponseData<GetRolesResponse,ResponseMessage>>
{
}
