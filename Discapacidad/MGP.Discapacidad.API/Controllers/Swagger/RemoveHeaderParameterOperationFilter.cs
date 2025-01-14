using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Linq;
namespace MGP.Discapacidad.API.Controllers.Swagger;
public class RemoveHeaderParameterOperationFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        // Eliminar los parámetros de encabezado "UserId" y "UserEmail" si  presentes
        operation.Parameters = operation.Parameters
            .Where(p => !(
                (p.Name.Equals("UserId", StringComparison.OrdinalIgnoreCase) ||
                 p.Name.Equals("UserEmail", StringComparison.OrdinalIgnoreCase) ||
                  p.Name.Equals("AgentId", StringComparison.OrdinalIgnoreCase))
                && p.In == ParameterLocation.Header))
            .ToList();
    }

}