using Swashbuckle.AspNetCore.Annotations;
namespace MGP.Authentication.API.Controllers.V1.User.Request;

public class ListUserByFiltersRequestModel
{
    /// <example>Cristian</example>
    [SwaggerSchema("Full Name")]
    public string FullName { get; set; }

    /// <example>17027227</example>
    [SwaggerSchema("Document Number")]
    public string DocumentNumber { get; set; }

    /// <example>1</example>
    [SwaggerSchema("Page Number")]
    public int PageNumber { get; set; }

    /// <example>10</example>
    [SwaggerSchema("Page Size")]
    public int PageSize { get; set; }
}
