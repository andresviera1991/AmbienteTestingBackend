using Swashbuckle.AspNetCore.Annotations;
namespace MGP.Authentication.API.Controllers.V1.Auth.Request.Register;

[SwaggerSchema("Data structure containing request details for creating a parent")]
public class ParentRequestModel
{
    /// <example>20345432</example>
    [SwaggerSchema("Parent's document number")]
    public string DocumentNumber { get; set; }

    /// <example>Juan</example>
    [SwaggerSchema("Parent's first name")]
    public string Name { get; set; }

    /// <example>Perez</example>
    [SwaggerSchema("Parent's last name")]
    public string LastName { get; set; }
}
