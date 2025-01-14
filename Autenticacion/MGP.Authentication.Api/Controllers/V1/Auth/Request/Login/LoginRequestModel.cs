using Swashbuckle.AspNetCore.Annotations;
namespace MGP.Authentication.API.Controllers.V1.Auth.Request.Login;

[SwaggerSchema("", Required = ["UserName", "Pasword"])]
public class LoginRequestModel
{
    /// <example>44413552</example>
    [SwaggerSchema("User's username")]
    public string UserName { get; set; }

    /// <example>Password_123</example>
    [SwaggerSchema("User's password")]
    public string Password { get; set; }
}
