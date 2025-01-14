using System;
namespace MGP.Authentication.Persistance.DTOs;

public class ResumeUserData
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public string DocumentNumber { get; set; }
    public DateTime BirthDate { get; set; }
    public UserStatusData Status { get; set; }

}
