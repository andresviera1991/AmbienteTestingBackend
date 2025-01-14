using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System.IO;
using System.Reflection;
using System;
using Asp.Versioning;

namespace MGP.Discapacidad.API.Controllers.Swagger;
public static class SwaggerConfiguration
{
    public static void AddSwaggerConfig(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "MGP.Discapacidad API V1",
                Version = "v1",
                Description = "Esta API proporciona las funcionalidades necesarias para el sistema de discapacidad (Generación de CUD Y SUBE)"
            });
            c.SwaggerDoc("v2", new OpenApiInfo
            {
                Title = "MGP.Discapacidad API V2",
                Version = "v2",
                Description = "Esta API proporciona las funcionalidades necesarias para el sistema de discapacidad (Generación de CUD Y SUBE)"
            });

            c.EnableAnnotations();
            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            c.IncludeXmlComments(xmlPath);

            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Description = "Encabezado de autorización JWT utilizando el esquema Bearer. Ejemplo: \"Authorization: Bearer {token}\"",
                Name = "Discapacidad",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.Http,
                Scheme = "bearer"
            });

            c.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                    }
                },
                Array.Empty<string>()
            }
            });
            c.OperationFilter<RemoveHeaderParameterOperationFilter>();

        });

        services.AddApiVersioning(options =>
        {
            options.DefaultApiVersion = new ApiVersion(2, 0);
            options.AssumeDefaultVersionWhenUnspecified = true;
            options.ReportApiVersions = true;
            options.ApiVersionReader = ApiVersionReader.Combine(
                new UrlSegmentApiVersionReader(),
                new HeaderApiVersionReader("X-Api-Version")
            );
        }).AddApiExplorer(options =>
        {
            options.GroupNameFormat = "'v'VVV";
            options.SubstituteApiVersionInUrl = true;
        });
    }
}