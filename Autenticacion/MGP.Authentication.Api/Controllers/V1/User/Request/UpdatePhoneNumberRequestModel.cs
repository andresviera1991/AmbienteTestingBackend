using Swashbuckle.AspNetCore.Annotations;
namespace MGP.Authentication.API.Controllers.V1.User.Request;

public class UpdatePhoneNumberRequestModel
{
    /// <example>22334565476</example>
    [SwaggerSchema("User's Telephone number")]
    public string Number { get; set; }
}
