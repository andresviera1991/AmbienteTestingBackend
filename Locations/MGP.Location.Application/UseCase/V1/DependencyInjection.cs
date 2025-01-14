using FluentValidation;
using MGP.Location.Application.UseCase.V1.Departments.GetDepartmentsByProvinceId;
using MGP.Location.Application.UseCase.V1.Locality.GetLocalitiesByDepartmentId;
using MGP.Location.Application.UseCase.V1.Locality.GetLocality;
using MGP.Location.Application.UseCase.V1.Province.GetAll;
using MGP.Location.Application.UseCase.V1.Street.GetStreetsByName;
using MGP.Location.Client;
using MGP.Location.Client.Interface;
using MGP.Location.Domain.interfaces;
using MGP.Location.Domain.Services;
using MGP.Location.Persistance;
using MGP.Location.Persistance.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MGP.Location.Application.UseCase.V1;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services, ConfigurationManager configuration)
    {
        var useDatabaseServices = configuration.GetValue<bool>("UseDatabaseServices");

        if (useDatabaseServices)
        {
            services.AddScoped<IProvinceService, ProvinceServiceDB>();
            services.AddScoped<IDepartmentService, DepartmentServiceDB>();
            services.AddScoped<ILocalityService, LocalityServiceDB>();
        }
        else
        {
            services.AddScoped<IProvinceService, ProvinceService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<ILocalityService, LocalityService>();
        }
        services.AddScoped<IStreetService, StreetServiceDB>();
        services.AddScoped<IValidator<GetAllProvincesRequest>, GetAllProvincesRequestValidator>();
        services.AddScoped<IProvinceRepository, ProvinceRepository>();
        services.AddScoped<IValidator<GetLocalitiesByDepartmentIdRequest>, GetLocalitiesByDepartmentIdRequestValidator>();
        services.AddScoped<ILocalityRepository, LocalityRepository>();
        services.AddScoped<IValidator<GetDepartmentsByProvinceIdRequest>, GetDepartmentsByProvinceIdRequestValidator>();
        services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        services.AddScoped<IValidator<GetStreetsByNameRequest>, GetStreetsByNameRequestValidator>();
        services.AddScoped<IStreetRepository, StreetRepository>();
        services.AddScoped<IValidator<GetLocalityRequest>, GetLocalityRequestValidator>();
        services.AddScoped<IGeoRefArClient, GeoRefArClient>();

        return services;
    }
}