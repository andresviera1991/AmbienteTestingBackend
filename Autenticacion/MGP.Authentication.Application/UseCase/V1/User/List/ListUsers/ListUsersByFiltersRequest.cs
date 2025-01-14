using Flunt.Notifications;
using MediatR;
using MGP.Authentication.CrossCutting.ResponseData;
namespace MGP.Authentication.Application.UseCase.V1.User.List.ListUsers;
public class ListUsersByFiltersRequest : Notifiable, IRequest<ResponseData<ListUsersByFiltersResponse, ResponseMessage>>
{
    public string FullName { get; set; }
    public string DocumentNumber { get; set; }
    public int PageSize { get; set; }
    public int PageNumber { get; set; }
}
