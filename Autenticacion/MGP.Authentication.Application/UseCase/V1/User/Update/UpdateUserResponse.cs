using MGP.Authentication.Persistance.DTOs;
using System;

namespace MGP.Authentication.Application.UseCase.V1.User.Update
{
    public class UpdateUserResponse
    {
        public Guid Id { get; set; }
        public Guid PersonId { get; set; }
        public PersonData Person { get; set; }
        public string Email { get; set; }
    }
}
