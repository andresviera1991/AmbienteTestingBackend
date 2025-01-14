using MGP.MisTramites.API.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MGP.MisTramites.CrossCutting.MessagesManager;
using MGP.MisTramites.API.Controllers.Swagger;
using Microsoft.Extensions.Configuration;
using MGP.MisTramites.Domain.Models;
using MGP.MisTramites.Application.UseCase.V1;
using Refit;
using MGP.MisTramites.Client.Interface.Authentication;
using System;
using MGP.MisTramites.Client.Interface.Discapacidad;
namespace MGP.MisTramites;
public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var configuration = builder.Configuration;

        builder.Services.Configure<GetTicketEndpoints>(builder.Configuration.GetSection("GetTicketEndpoints"));      
        builder.Services.Configure<ListTicketEndpoints>(builder.Configuration);

        builder.Services.AddApplication();
        builder.Services.AddHttpClient();
        builder.Services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            cfg.RegisterServicesFromAssembly(Assembly.Load("MGP.MisTramites.Application"));
        });

        builder.Services.AddRefitClient<IDiscapacidadApi>().SetHandlerLifetime(TimeSpan.FromMinutes(2));

        builder.Services.AddRefitClient<IAuthenticationApi>()
        .ConfigureHttpClient(c => c.BaseAddress = new Uri(configuration.GetValue<string>("AuthenticationUri")))
        .SetHandlerLifetime(TimeSpan.FromMinutes(2));


        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddSwaggerConfig();
        builder.Services.AddAutoMapper(typeof(AutoMapping));

        var corsConfig = "MisTramitesMGP";
        builder.Services.AddCors(setup =>
        {
            setup.AddPolicy(corsConfig, x =>
            {
                x.WithOrigins(builder.Configuration.GetValue<string>("Origins")!);
                x.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });

        builder.Services.ConfigureMessageManager();
        var app = builder.Build();
        app.UseCors(corsConfig);
        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mis Tickets API V1");
            c.RoutePrefix = string.Empty;
        });

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}
