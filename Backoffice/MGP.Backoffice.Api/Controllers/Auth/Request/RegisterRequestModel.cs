using MGP.Backoffice.Api.Controllers.Agent.Request.Update;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.Backoffice.Api.Controllers.Auth;

[SwaggerSchema("Contiene la definición para la creación de usuarios",
    Required = new string[] { "Employee Number", "First Name", "Last Name", "Document Number", "Email", "Role User" })]
public class RegisterRequestModel
{
    /// <example>JAGENTE</example>
    [SwaggerSchema("User Name")]
    public string UserName { get; set; }

    /// <example>882537</example>
    [SwaggerSchema("Employee Number")]
    public string EmployeeNumber { get; set; }

    /// <example>John</example>
    [SwaggerSchema("First Name")]
    public string FirstName { get; set; }

    /// <example>Agente</example>
    [SwaggerSchema("Last Name")]
    public string LastName { get; set; }

    /// <example>17027227</example>
    [SwaggerSchema("Document Number")]
    public string DocumentNumber { get; set; }

    /// <example>c.fernandez.melian@hotmail.com</example>
    [SwaggerSchema("Email")]
    public string Email { get; set; }

    /// <example>AGENTE</example>
    [SwaggerSchema("Role User")]
    public string Role { get; set; }

    /// <example>1</example>
    [SwaggerSchema("Area Id")]
    public int AreaId { get; set; }

    public List<TicketTypeRequestModel> ManagedTicketTypes { get; set; }

}
