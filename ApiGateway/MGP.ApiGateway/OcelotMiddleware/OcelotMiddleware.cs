using Newtonsoft.Json;
using Ocelot.DependencyInjection;
using System.Text;
using System.IO;

namespace MGP.ApiGateway.OcelotMiddleware;

public static class OcelotMiddlConfiguration
{
    public static IServiceCollection AddOcelotConfiguration(this IServiceCollection services, ConfigurationManager configuration, IWebHostEnvironment environment)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(environment.ContentRootPath)
            .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true)
            .AddJsonFile("Endpoints/Microservices/authentication.json", optional: false, reloadOnChange: true)
            .AddJsonFile("Endpoints/Microservices/discapacidad.json", optional: false, reloadOnChange: true)
            .AddJsonFile("Endpoints/Microservices/audit.json", optional: false, reloadOnChange: true)
            .AddJsonFile("Endpoints/Microservices/backoffice.json", optional: false, reloadOnChange: true)
            .AddJsonFile("Endpoints/Microservices/location.json", optional: false, reloadOnChange: true)
            .AddJsonFile("Endpoints/Microservices/mis-tramites.json", optional: false, reloadOnChange: true)

            .AddEnvironmentVariables();

        var tempConfig = builder.Build();

        var authenticationRoutes = tempConfig.GetSection("AuthenticationRoutes").Get<List<Route>>() ?? new List<Route>();
        var discapacidadRoutes = tempConfig.GetSection("DiscapacidadRoutes").Get<List<Route>>() ?? new List<Route>();
        var auditRoutes = tempConfig.GetSection("AuditRoutes").Get<List<Route>>() ?? new List<Route>();
        var backofficeRoutes = tempConfig.GetSection("BackofficeRoutes").Get<List<Route>>() ?? new List<Route>();
        var locationRoutes = tempConfig.GetSection("LocationsRoutes").Get<List<Route>>() ?? new List<Route>();
        var misTramitesRoutes = tempConfig.GetSection("MisTramitesRoutes").Get<List<Route>>() ?? new List<Route>();

        var combinedRoutes = authenticationRoutes.Concat(discapacidadRoutes)
                                                 .Concat(auditRoutes)
                                                 .Concat(backofficeRoutes)
                                                 .Concat(locationRoutes)
                                                 .Concat(misTramitesRoutes)
                                                 .ToList();

        var routesConfig = new { Routes = combinedRoutes };

        var jsonRoutes = JsonConvert.SerializeObject(routesConfig, Formatting.Indented);

        var jsonFilePath = Path.Combine(environment.ContentRootPath, "Endpoints", "ocelot.json");

        File.WriteAllText(jsonFilePath, jsonRoutes);

        configuration.AddJsonFile($"Endpoints/ocelot.json", optional: false, reloadOnChange: true);
        services.AddOcelot(configuration);

        return services;
    }
}
