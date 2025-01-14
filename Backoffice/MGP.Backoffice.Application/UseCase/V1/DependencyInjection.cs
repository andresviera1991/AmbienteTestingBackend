using FluentValidation;
using MGP.Backoffice.Application.UseCase.V1.AddAgentLeave;
using MGP.Backoffice.Application.UseCase.V1.Auth.ChangePassword;
using MGP.Backoffice.Application.UseCase.V1.Auth.Login;
using MGP.Backoffice.Application.UseCase.V1.Auth.Logout;
using MGP.Backoffice.Application.UseCase.V1.Auth.NewTokens;
using MGP.Backoffice.Application.UseCase.V1.Auth.Register;
using MGP.Backoffice.Application.UseCase.V1.Auth.ResetPassword;
using MGP.Backoffice.Application.UseCase.V1.GetAgent;
using MGP.Backoffice.Application.UseCase.V1.GetAgentLeave;
using MGP.Backoffice.Application.UseCase.V1.Menu;
using MGP.Backoffice.Application.UseCase.V1.UpdateAgentLeave;
using MGP.Backoffice.Domain.Helper;
using MGP.Backoffice.Domain.Interface;
using MGP.Backoffice.Domain.Interfaces;
using MGP.Backoffice.Domain.Services;
using MGP.Backoffice.Domain;
using MGP.Backoffice.Persistance.Interface;
using MGP.Backoffice.Persistance.Interfaces;
using MGP.Backoffice.Persistance;
using Microsoft.Extensions.DependencyInjection;
using MGP.Backoffice.Application.UseCase.V1.NextAvailableAgent;
using MGP.Backoffice.Application.UseCase.V1.UpdateAgent;
using MGP.Backoffice.Application.UseCase.V1.ListAgents.ListByFilters;
using MGP.Backoffice.Application.UseCase.V1.ListAgents.ListByTicketType;

namespace MGP.Backoffice.Application.UseCase.V1;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {

        services.AddScoped<IValidator<ListAgentByFiltersRequest>, ListAgentByFiltersRequestValidator>();
        services.AddScoped<IValidator<GetAgentRequest>, GetAgentRequestValidator>();
        services.AddScoped<IValidator<RegisterRequest>, RegisterRequestValidator>();
        services.AddScoped<IValidator<LoginRequest>, LoginRequestValidator>();
        services.AddScoped<IValidator<NewTokensRequest>, NewTokensRequestValidator>();
        services.AddScoped<IValidator<LogoutRequest>, LogoutRequestValidator>();
        services.AddScoped<IValidator<GetMenuRequest>, GetMenuRequestValidator>();
        services.AddScoped<IValidator<ChangePasswordRequest>, ChangePasswordRequestValidator>();
        services.AddScoped<IValidator<ResetPasswordRequest>, ResetPasswordRequestValidator>();
        services.AddScoped<IValidator<AddAgentLeaveRequest>, AddAgentLeaveRequestValidator>();
        services.AddScoped<IValidator<GetAgentLeaveRequest>, GetAgentLeaveRequestValidator>();
        services.AddScoped<IValidator<UpdateAgentLeaveRequest>, UpdateAgentLeaveRequestValidator>();
        services.AddScoped<IValidator<ListAgentByFiltersRequest>, ListAgentByFiltersRequestValidator>();
        services.AddScoped<IValidator<ListAgentByTicketTypeRequest>, ListAgentByTicketTypeRequestValidator>();

        services.AddScoped<IAreaRepository, AreaRepository>();
        services.AddScoped<ITicketTypeRepository, TicketTypeRepository>();

        services.AddScoped<IAgentLeaveRepository, AgentLeaveRepository>();
        services.AddScoped<ILoginRepository, LoginRepository>();
        services.AddScoped<IMenuRepository, MenuRepository>();
        services.AddScoped<IAreaRepository, AreaRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IEmailRepository, EmailRepository>();
        services.AddScoped<ICatalogRepository, CatalogRepository>();
        services.AddScoped<IAgentLeaveRepository, AgentLeaveRepository>();
        services.AddScoped<IValidator<NextAvailableAgentRequest>, NextAvailableAgentRequestValidator>();
        services.AddScoped<ILoginService, LoginService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IAuditService, AuditService>();

        services.AddScoped<IEmailService, EmailService>();
        services.AddScoped<IMenuService, MenuService>();
        services.AddScoped<IAgentLeaveService, AgentLeaveService>();
        services.AddScoped<ICatalogService, CatalogService>();
        services.AddScoped<IJwtValidator, JwtValidator>();
        services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();

        services.AddScoped<IValidator<UpdateAgentRequest>, UpdateAgentRequestValidator>();


        return services;
    }
}