using Swashbuckle.AspNetCore.Annotations;
namespace MGP.Authentication.API.Controllers.V1.Auth.Request.Register;
public class PhoneNumberRequestModel
{
    /// <example>22334565476</example>
    [SwaggerSchema("User's Telephone number")]
    public string Number { get; set; }
}
