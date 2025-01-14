using System;

namespace MGP.Authentication.Persistance.DTOs
{
    public class UserData
    {
        public Guid Id { get; set; }
        public Guid PersonId { get; set; }  
        public PersonData Person { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
