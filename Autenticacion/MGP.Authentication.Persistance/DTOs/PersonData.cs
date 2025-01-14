using System;
namespace MGP.Authentication.Persistance.DTOs;

public class PersonData
{
    public Guid Id { get; set; }
    public string DocumentNumber { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public int GenderId { get; set; }
    public bool Resident { get; set; }
    public AddressData Address { get; set; }
    public PhoneNumberData PhoneNumber { get; set; }
    public ParentData Parent { get; set; }
}
