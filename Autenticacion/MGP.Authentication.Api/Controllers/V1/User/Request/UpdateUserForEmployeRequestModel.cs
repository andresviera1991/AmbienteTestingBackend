using Swashbuckle.AspNetCore.Annotations;
using System;
namespace MGP.Authentication.API.Controllers.V1.User.Request;

[SwaggerSchema("Data structure containing request details for update user",
    Required = new string[] { "UserStatusId", "User Id" })]
public class UpdateUserForEmployeRequestModel
{

    /// <example>1</example>
    [SwaggerSchema("UserStatusId")]
    public int? UserStatusId { get; set; }

    /// <example>5775231a-1586-4492-a5a4-83504ed980a7</example>
    [SwaggerSchema("User Id")]
    public Guid? UserId { get; set; }

    /// <example>cristian.fer.mel@gmail.com</example>
    [SwaggerSchema("User's email")]
    public string Email { get; set; }

    [SwaggerSchema("Person's data")]
    public UpdatePersonRequestModel Person { get; set; }
}
