using FluentValidation;
using MGP.Authentication.Application.UseCase.V1.Authentication.Login;
using MGP.Authentication.Application.UseCase.V1.Authentication.Logout;
using MGP.Authentication.Application.UseCase.V1.Authentication.RefreshSessionToken;
using MGP.Authentication.Application.UseCase.V1.Authentication.Register;
using MGP.Authentication.Application.UseCase.V1.Authentication.RegisterByAgent;
using MGP.Authentication.Application.UseCase.V1.Authentication.ValidateUser;
using MGP.Authentication.Application.UseCase.V1.Password.Change;
using MGP.Authentication.Application.UseCase.V1.Password.Reset;
using MGP.Authentication.Application.UseCase.V1.Password.ResetSendEmail;
using MGP.Authentication.Application.UseCase.V1.ResetPassword.ValidToken;
using MGP.Authentication.Application.UseCase.V1.User.Delete;
using MGP.Authentication.Application.UseCase.V1.User.GetUser;
using MGP.Authentication.Application.UseCase.V1.User.List.ListUserIds;
using MGP.Authentication.Application.UseCase.V1.User.List.ListUsers;
using MGP.Authentication.Application.UseCase.V1.User.Update;
using MGP.Authentication.Domain.Helper;
using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Domain.Services;
using MGP.Authentication.Persistance;
using MGP.Authentication.Persistance.Interface;
using Microsoft.Extensions.DependencyInjection;
namespace MGP.Authentication.Application.UseCase.V1;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ILoginService, LoginService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IEmailService, EmailService>();
        services.AddScoped<IPasswordService, PasswordService>();
        services.AddScoped<IEncryptionService, EncryptionService>();
        services.AddScoped<ICatalogService, CatalogService>();
        services.AddScoped<IAuditService, AuditService>();
        services.AddScoped<IParentService, ParentService>();
        services.AddScoped<ILoginRepository, LoginRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IPasswordRepository, PasswordRepository>();
        services.AddScoped<ICatalogRepository, CatalogRepository>();
        services.AddScoped<IParentRepository, ParentRepository>();
        services.AddScoped<IEmailRepository, EmailRepository>();
        services.AddScoped<IValidator<RegisterRequest>, RegisterRequestValidator>();
        services.AddScoped<IValidator<RegisterByAgentRequest>, RegisterByAgentRequestValidator>();
        services.AddScoped<IValidator<LoginRequest>, LoginRequestValidator>();
        services.AddScoped<IValidator<ValidateRegisterRequest>, ValidateRegisterValidator>();
        services.AddScoped<IValidator<ValidateTokenRequest>, ValidateTokenValidator>();
        services.AddScoped<IValidator<ResetPasswordRequest>, ResetPasswordValidator>();
        services.AddScoped<IValidator<LogoutRequest>, LogoutValidator>();
        services.AddScoped<IValidator<NewSessionTokenRequest>, NewSessionTokenValidator>();
        services.AddScoped<IValidator<UpdateUserRequest>, UpdateUserRequestValidator>();
        services.AddScoped<IValidator<GetUserRequest>, GetUserRequestValidator>();
        services.AddScoped<IValidator<DeleteUserRequest>, DeleteUserRequestValidator>();
        services.AddScoped<IValidator<ChangePasswordRequest>, ChangePasswordValidator>();
        services.AddScoped<IValidator<ListUserIdsByFiltersRequest>, ListUserIdsByFiltersRequestValidator>();
        services.AddScoped<IValidator<ListUsersByFiltersRequest>, ListUsersByFiltersRequestValidator>();
        services.AddScoped<IValidator<ResetPasswordEmailRequest>, ResetPasswordEmailValidator>();
        services.AddScoped<IJwtValidator, JwtValidator>();
        services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();

        return services;
    }
}