using Swashbuckle.AspNetCore.Annotations;
namespace MGP.Authentication.API.Controllers.V1.User.Request;

[SwaggerSchema("Data structure containing request details for update user",
    Required = ["Email"])]
public class UpdateUserRequestModel
{
    /// <example>cristian.fer.mel@gmail.com</example>
    [SwaggerSchema("User's email")]
    public string Email { get; set; }

    [SwaggerSchema("Person's data")]
    public UpdatePersonRequestModel Person { get; set; }
}
