using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Linq;
namespace MGP.Authentication.API.Controllers.Swagger;

public class RemoveHeaderParameterOperationFilter : IOperationFilter
{
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        operation.Parameters = operation.Parameters
            .Where(p => !(p.Name.Equals("role", StringComparison.OrdinalIgnoreCase) && p.In == ParameterLocation.Header))
            .ToList();

        operation.Parameters = operation.Parameters
            .Where(p => !(p.Name.Equals("area", StringComparison.OrdinalIgnoreCase) && p.In == ParameterLocation.Header))
            .ToList();

        operation.Parameters = operation.Parameters
            .Where(p => !(p.Name.Equals("employeeId", StringComparison.OrdinalIgnoreCase) && p.In == ParameterLocation.Header))
            .ToList();
    }
}