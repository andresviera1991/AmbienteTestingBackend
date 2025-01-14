using FluentValidation;
using MGP.MisTramites.Client;
using MGP.MisTramites.Client.Interface.Authentication;
using MGP.MisTramites.Client.Interface.Discapacidad;
using MGP.MisTramites.Application.UseCase.V1.Agent.GetTicket;
using MGP.MisTramites.Application.UseCase.V1.Agent.ListTickets;
using MGP.MisTramites.Application.UseCase.V1.User.GetTicket;
using MGP.MisTramites.Application.UseCase.V1.User.ListTickets;
using MGP.MisTramites.Domain.Interfaces;
using MGP.MisTramites.Domain.Service;
using Microsoft.Extensions.DependencyInjection;
namespace MGP.MisTramites.Application.UseCase.V1;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IValidator<ListTicketUserRequest>, ListTicketUserRequestValidator>();
        services.AddScoped<IValidator<ListTicketAgentRequest>, ListTicketAgentRequestValidator>();
        services.AddScoped<IValidator<GetTicketUserRequest>, GetTicketUserRequestValidator>();
        services.AddScoped<IValidator<GetTicketAgentRequest>, GetTicketAgentRequestValidator>();
        services.AddScoped<IAuthenticationClient, AuthenticationClient>();
        services.AddScoped<IDiscapacidadClient, DiscapacidadClient>();

        services.AddScoped<ITicketService, TicketService>();

        return services;
    }
}