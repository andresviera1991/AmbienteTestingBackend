using Swashbuckle.AspNetCore.Annotations;
namespace MGP.Backoffice.Api.Controllers.Agent.Request;

public class ListAgentByFiltersRequestModel
{
    /// <example>AGENTE</example>
    [SwaggerSchema("Role")]
    public string Role { get; set; }

    /// <example>DISCAPACIDAD</example>
    [SwaggerSchema("Area")]
    public string Area { get; set; }

    /// <example>1111111</example>
    [SwaggerSchema("Employee Number")]
    public string EmployeeNumber { get; set; }

    /// <example>Cristian Agente</example>
    [SwaggerSchema("FullName")]
    public string FullName { get; set; }

    /// <example>17027227</example>
    [SwaggerSchema("Document Number")]
    public string DocumentNumber { get; set; }

    /// <example>1</example>
    [SwaggerSchema("User Status Id")]
    public int? UserStatusId { get; set; }

    /// <example>1</example>
    [SwaggerSchema("Page Number")]
    public int PageNumber { get; set; }

    /// <example>10</example>
    [SwaggerSchema("Page Size")]
    public int PageSize { get; set; }
}
