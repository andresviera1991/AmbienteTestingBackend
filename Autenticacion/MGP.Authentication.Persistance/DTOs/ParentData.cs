using System;
namespace MGP.Authentication.Persistance.DTOs;
public class ParentData
{
    public Guid Id { get; set; }
    public string DocumentNumber { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public Guid PersonId { get; set; }
    public PersonData Person { get; set; }
}
