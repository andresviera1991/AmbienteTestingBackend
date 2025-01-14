using MGP.Authentication.Persistance.DTOs;
using System;
namespace MGP.Authentication.Application.UseCase.V1.User.Update.Request;

public class PersonUpdateUserRequest
{
    public Guid? Id { get; set; }
    public string DocumentNumber { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime? BirthDate { get; set; }
    public int? GenderId { get; set; }
    public bool? Resident { get; set; }

    public AddressUpdateUserRequest Address { get; set; }
    public PhoneNumberUpdateUserRequest PhoneNumber { get; set; }
    public ParentData Parent { get; set; }

}
