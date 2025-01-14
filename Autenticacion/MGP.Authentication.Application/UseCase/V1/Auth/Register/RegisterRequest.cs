using Flunt.Notifications;
using MediatR;
using MGP.Authentication.CrossCutting.ResponseData;
using MGP.Authentication.Persistance.DTOs;

namespace MGP.Authentication.Application.UseCase.V1.Authentication.Register
{
    public class RegisterRequest : Notifiable, IRequest<ResponseData<RegisterResponse, ResponseMessage>>
    {
        public string Password { get; set; }

        public PersonData Person { get; set; }

        public string Email { get; set; }
    }
}
