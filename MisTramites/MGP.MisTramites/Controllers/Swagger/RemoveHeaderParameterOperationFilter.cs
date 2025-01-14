using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Linq;

namespace MGP.MisTramites.API.Controllers.Swagger
{
    public class RemoveHeaderParameterOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            // Eliminar el parámetro de encabezado "UserId" si está presente
            operation.Parameters = operation.Parameters
                .Where(p => !(p.Name.Equals("UserId", StringComparison.OrdinalIgnoreCase) && p.In == ParameterLocation.Header))
                .ToList();

            operation.Parameters = operation.Parameters
                .Where(p => !(p.Name.Equals("EmployeeId", StringComparison.OrdinalIgnoreCase) && p.In == ParameterLocation.Header))
                .ToList();
        }
    }
}