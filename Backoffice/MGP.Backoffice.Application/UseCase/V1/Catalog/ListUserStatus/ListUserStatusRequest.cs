using Flunt.Notifications;
using MediatR;
using MGP.Backoffice.CrossCutting.ResponseData;
namespace MGP.Backoffice.Application.UseCase.V1.Catalog.ListUserStatus;
public class ListUserStatusRequest : Notifiable, IRequest<ResponseData<ListUserStatusResponse,ResponseMessage>>
{
}
