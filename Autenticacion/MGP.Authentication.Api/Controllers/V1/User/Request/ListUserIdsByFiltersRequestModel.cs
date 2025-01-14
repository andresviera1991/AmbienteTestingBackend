using Swashbuckle.AspNetCore.Annotations;
namespace MGP.Authentication.API.Controllers.V1.User.Request;

public class ListUserIdsByFiltersRequestModel
{
    /// <example>Cristian</example>
    [SwaggerSchema("Full Name")]
    public string FullName { get; set; }

    /// <example>17027227</example>
    [SwaggerSchema("Document Number")]
    public string DocumentNumber { get; set; }
}
