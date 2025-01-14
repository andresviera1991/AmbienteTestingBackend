using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;

namespace MGP.Backoffice.Api.Controllers.Agent.Request.Update;
public class UpdateAgentRequestModel
{
    /// <example>7bc0fe46-886e-41d1-a8de-3cf4ab5ffa5f</example>
    [SwaggerSchema("Agent Id")]
    public Guid AgentId { get; set; }

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

    /// <example>1</example>
    [SwaggerSchema("User Status Id")]
    public int UserStatusId { get; set; }

    public List<TicketTypeRequestModel> ManagedTicketTypes { get; set; }
}
