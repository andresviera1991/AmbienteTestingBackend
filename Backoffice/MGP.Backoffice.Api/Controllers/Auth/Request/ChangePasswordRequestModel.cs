using Swashbuckle.AspNetCore.Annotations;
namespace MGP.Authentication.API.Controllers.V1.Password.Request;

[SwaggerSchema(Required = new string[] { "CurrentPassword", "NewPassword" })]
public class ChangePasswordRequestModel
{
    /// <example>Password_123</example>
    [SwaggerSchema("Current User's Password")]
    public string CurrentPassword { get; set; }

    /// <example>NewPassword</example>
    [SwaggerSchema("New User's Password")]
    public string NewPassword { get; set; }
}
