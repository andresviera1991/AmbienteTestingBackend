using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;

namespace MGP.Authentication.API.Controllers.Swagger.Messages;

public class SamePasswordError
{
    /// <summary>
    /// Example list of error messages
    /// </summary>
    /// <example>["La contraseña no puede ser la misma que la anterior"]</example>
    [SwaggerSchema("List of error messages")]
    public List<string> Message { get; set; }
}
