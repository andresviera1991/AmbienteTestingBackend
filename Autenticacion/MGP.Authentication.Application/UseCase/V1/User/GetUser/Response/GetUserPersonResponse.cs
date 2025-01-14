using MGP.Authentication.Persistance.DTOs;
using System;

namespace MGP.Authentication.Application.UseCase.V1.User.GetUser.Response
{
    public class GetUserPersonResponse
    {
        public string DocumentNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int GenderId { get; set; }
        public bool Resident { get; set; }
        public GetUserPersonAddressResponse Address { get; set; }
        public GetUserPersonPhoneNumberResponse PhoneNumber { get; set; }
        public ParentData Parent { get; set; }
    }
}
