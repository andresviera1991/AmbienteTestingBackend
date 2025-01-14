using System;

namespace MGP.Authentication.Persistance.DTOs
{
    public class UserDataToUpdate : UserData
    {
        public new Guid? Id { get; set; }
        public int? UserStatusId { get; set; }
        public new Guid? PersonId { get; set; }
        public new PersonDataToUpdate Person { get; set; }
    }
}
