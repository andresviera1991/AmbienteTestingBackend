using FluentValidation;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.CUD.Get;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.CUD.Update;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.List.ListTicketByAgent;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.PARKING.Get;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.PARKING.Update;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.SUBE.Get;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.SUBE.Update;
using MGP.Discapacidad.Application.UseCase.V1.Chat.AddMessage;
using MGP.Discapacidad.Application.UseCase.V1.Chat.GetMessages;
using MGP.Discapacidad.Application.UseCase.V1.Chat.VerifyTicket;
using MGP.Discapacidad.Application.UseCase.V1.Document.AddDocument;
using MGP.Discapacidad.Application.UseCase.V1.Document.RemoveDocument;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.CUD.Create;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.CUD.Get;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.List.ListTicketByUser;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.PARKING.Create;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.PARKING.Get;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.SUBE.Create;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.SUBE.Get;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.Update;
using MGP.Discapacidad.Client;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Domain.Interfaces;
using MGP.Discapacidad.Domain.Services;
using MGP.Discapacidad.Persistance;
using MGP.Discapacidad.Persistance.Interface;
using Microsoft.Extensions.DependencyInjection;
using MGP.Discapacidad.Application.UseCase.V1.Supervisor.ReassignTicket;
using MGP.Discapacidad.Application.UseCase.V1.Document.AddTemplate;
using MGP.Discapacidad.Application.UseCase.V1.Document.UpdateTemplate;
using MGP.Discapacidad.Application.UseCase.V1.Document.RemoveTemplate;
using MGP.Discapacidad.Client.Interface.Backoffice;
using MGP.Discapacidad.Client.Interface.Authentication;
namespace MGP.Discapacidad.Application.UseCase.V1;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IValidator<CreateTicketCudRequest>, CreateTicketCudRequestValidator>();
        services.AddScoped<IValidator<CreateTicketSubeRequest>, CreateTicketSubeRequestValidator>();
        services.AddScoped<IValidator<CreateTicketParkingRequest>, CreateTicketParkingRequestValidator>();
        services.AddScoped<IValidator<GetTicketCudAgentRequest>, GetTicketCudAgentRequestValidator>();
        services.AddScoped<IValidator<GetTicketSubeAgentRequest>, GetTicketSubeAgentRequestValidator>();
        services.AddScoped<IValidator<GetTicketParkingAgentRequest>, GetTicketParkingAgentRequestValidator>();
        services.AddScoped<IValidator<GetTicketCudUserRequest>, GetTicketCudUserRequestValidator>();
        services.AddScoped<IValidator<GetTicketSubeUserRequest>, GetTicketSubeUserRequestValidator>();
        services.AddScoped<IValidator<GetTicketParkingUserRequest>, GetTicketParkingUserRequestValidator>();
        services.AddScoped<IValidator<UpdateTicketCudRequest>, UpdateTicketCudRequestValidator>();
        services.AddScoped<IValidator<UpdateTicketSubeRequest>, UpdateTicketSubeRequestValidator>();
        services.AddScoped<IValidator<UpdateTicketParkingRequest>, UpdateTicketParkingRequestValidator>();
        services.AddScoped<IValidator<ListTicketUserRequest>, ListTicketUserRequestValidator>();
        services.AddScoped<IValidator<ListTicketAgentRequest>, ListTicketAgentRequestValidator>();
        services.AddScoped<IValidator<CancelTicketRequest>, CancelTicketRequestValidator>();
        services.AddScoped<IValidator<AddDocumentRequestList>, AddDocumentRequestValidator>();
        services.AddScoped<IValidator<RemoveDocumentRequest>, RemoveDocumentRequestValidator>();
        services.AddScoped<IValidator<TicketExistRequest>, TicketExistRequestValidator>();
        services.AddScoped<IValidator<AddMessageRequest>, AddMessageRequestValidator>();
        services.AddScoped<IValidator<GetMessagesRequest>, GetMessagesRequestValidator>();
        services.AddScoped<IValidator<ReassignTicketRequest>, ReassignTicketRequestValidator>();
        services.AddScoped<IValidator<AddTemplateRequest>, AddTemplateRequestValidator>();
        services.AddScoped<IValidator<UpdateTemplateRequest>, UpdateTemplateRequestValidator>();
        services.AddScoped<IValidator<RemoveTemplateRequest>, RemoveTemplateRequestValidator>();
        services.AddScoped<ITicketService, TicketService>();
        services.AddScoped<IDocumentService, DocumentService>();
        services.AddScoped<ICatalogService, CatalogService>();
        services.AddScoped<IEmailService, EmailService>();
        services.AddScoped<IAuditService, AuditService>();
        services.AddScoped<IChatService, ChatService>();
        services.AddScoped<INotificationService, NotificationService>();
        services.AddScoped<IDocumentRepository, DocumentRepository>();
        services.AddScoped<ITicketRepository, TicketRepository>();
        services.AddScoped<ICatalogRepository, CatalogRepository>();
        services.AddScoped<IChatRepository, ChatRepository>();
        services.AddScoped<IEmailRepository, EmailRepository>();
        services.AddScoped<IBackofficeClient, BackofficeClient>();
        services.AddScoped<IAuthenticationClient, AuthenticationClient>();


        return services;
    }
}