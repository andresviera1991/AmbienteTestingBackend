using Swashbuckle.AspNetCore.Annotations;
namespace MGP.Authentication.API.Controllers.V1.ResetPassword.Request;

[SwaggerSchema(Required = ["NewPassword", "Token"])]
public class ResetPasswordRequestModel
{

    /// <example>NewPassword</example>
    [SwaggerSchema("New User's Password")]
    public string NewPassword { get; set; }

    [SwaggerSchema("Token")]
    public string Token { get; set; }
}
