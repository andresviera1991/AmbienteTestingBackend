using MGP.Authentication.API.Controllers.V1.Auth.Request.Register;
using Swashbuckle.AspNetCore.Annotations;
namespace MGP.Authentication.API.Controllers.V1.Auth.Request.RegisterByAgent;

[SwaggerSchema("Data structure containing request details for creating a user",Required = ["Password", "EmailAddress"])]
public class RegisterByAgentRequestModel
{
    public PersonRequestModel Person { get; set; }

    /// <example>cristian.fer.mel@gmail.com</example>
    [SwaggerSchema("User's email")]
    public string Email { get; set; }

}