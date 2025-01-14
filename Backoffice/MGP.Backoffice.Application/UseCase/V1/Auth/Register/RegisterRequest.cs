using Flunt.Notifications;
using MediatR;
using MGP.Backoffice.CrossCutting.ResponseData;
using MGP.Backoffice.Domain.DTOs;
namespace MGP.Backoffice.Application.UseCase.V1.Auth.Register;

public class RegisterRequest : Notifiable, IRequest<ResponseData<RegisterResponse, ResponseMessage>>
{
    public string UserName { get; set; }
    public string EmployeeNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DocumentNumber { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public int AreaId { get; set; }
    public List<TicketTypeData> ManagedTicketTypes { get; set; }

}
