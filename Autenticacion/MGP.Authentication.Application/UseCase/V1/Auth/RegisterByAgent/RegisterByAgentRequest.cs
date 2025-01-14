using Flunt.Notifications;
using MediatR;
using MGP.Authentication.CrossCutting.ResponseData;
using MGP.Authentication.Persistance.DTOs;

namespace MGP.Authentication.Application.UseCase.V1.Authentication.RegisterByAgent
{
    public class RegisterByAgentRequest : Notifiable, IRequest<ResponseData<RegisterByAgentResponse, ResponseMessage>>
    {

        public PersonData Person { get; set; }

        public string Email { get; set; }
    }
}
