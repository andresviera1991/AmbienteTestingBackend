using Swashbuckle.AspNetCore.Annotations;
namespace MGP.Authentication.API.Controllers.V1.Auth.Request.Register;

[SwaggerSchema("Data structure containing request details for creating a user",Required = ["Password", "EmailAddress"])]
public class RegisterRequestModel
{
    /// <example>Password_123</example>
    [SwaggerSchema("User's password")]
    public string Password { get; set; }
    public PersonRequestModel Person { get; set; }

    /// <example>cristian.fer.mel@gmail.com</example>
    [SwaggerSchema("User's email")]
    public string Email { get; set; }
}