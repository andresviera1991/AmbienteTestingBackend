using System;

namespace MGP.Authentication.Persistance.DTOs
{
    public class PersonDataToUpdate : PersonData
    {
        public new Guid? Id { get; set; }
        public new DateTime? BirthDate { get; set; }
        public new int? GenderId { get; set; }
        public new bool? Resident { get; set; }

        public new AddressDataToUpdate Address { get; set; }
        public new ParentData Parent { get; set; }

    }
}
