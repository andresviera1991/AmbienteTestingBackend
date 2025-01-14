using MGP.Audit.Domain.interfaces;
using MGP.Audit.Domain.Services;
using MGP.Audit.Persistance.Interface;
using MGP.Audit.Persistance;
using Microsoft.Extensions.DependencyInjection;
namespace MGP.Audit.Application.UseCase.V1;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuditService, AuditService>();
        services.AddScoped<IAuditRepository, AuditRepository>();
        return services;
    }
}