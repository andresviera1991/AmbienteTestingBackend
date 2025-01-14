using AutoMapper;
using MGP.Discapacidad.Persistance.Data.Tables;
using MGP.Discapacidad.Persistance.DTOs.Catalog;
using MGP.Discapacidad.Persistance.DTOs.Ticket;
using MGP.Discapacidad.Application.UseCase.V1.Document.AddDocument;
using MGP.Discapacidad.API.Controllers.V1.Document.Request;
using MGP.Discapacidad.Persistance.DTOs.Document;
using MGP.Discapacidad.API.Controllers.V1.Documentation.Request;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.CUD.Create;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.PARKING.Create;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.SUBE.Create;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.CUD.Update;
using System;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.SUBE.Update;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.PARKING.Update;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.List.ListTicketByAgent;
using MGP.Discapacidad.API.Controllers.V1.Chat.Request;
using MGP.Discapacidad.Application.UseCase.V1.Chat.AddMessage;
using MGP.Discapacidad.Persistance.DTOs.Chat;
using MGP.Discapacidad.Application.UseCase.V1.Chat.GetMessages;
using MGP.Discapacidad.API.Controllers.V1.Ticket.UserTicket.Request;
using MGP.Discapacidad.API.Controllers.V1.Ticket.AgentTicket.Request;
using MGP.Discapacidad.API.Controllers.V1.Ticket.SupervisorTicket.Request;
using MGP.Discapacidad.Application.UseCase.V1.Supervisor.ReassignTicket;
using MGP.Discapacidad.Application.UseCase.V1.Document.AddTemplate;
using MGP.Discapacidad.Application.UseCase.V1.Document.UpdateTemplate;
namespace MGP.Discapacidad.API.Helper;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        ModelToRequest();
        RequestToDTO();
        DTOToEntity();
        EntityToDTO();
        DTOToResponse();
    }

    #region Request To Database
    private void ModelToRequest()
    {
        CreateMap<CreateTicketCudRequestModel, CreateTicketCudRequest>()
        .ForMember(dest => dest.Documents, opt => opt.MapFrom(src => src.Documents));

        CreateMap<CreateTicketSubeRequestModel, CreateTicketSubeRequest>()
        .ForMember(dest => dest.Documents, opt => opt.MapFrom(src => src.Documents));

        CreateMap<CreateTicketParkingRequestModel, CreateTicketParkingRequest>()
        .ForMember(dest => dest.Documents, opt => opt.MapFrom(src => src.Documents));

        CreateMap<CreateTicketCudAgentRequestModel, CreateTicketCudRequest>()
        .ForMember(dest => dest.Documents, opt => opt.MapFrom(src => src.Documents));

        CreateMap<CreateTicketSubeAgentRequestModel, CreateTicketSubeRequest>()
        .ForMember(dest => dest.Documents, opt => opt.MapFrom(src => src.Documents));

        CreateMap<CreateTicketParkingAgentRequestModel, CreateTicketParkingRequest>()
        .ForMember(dest => dest.Documents, opt => opt.MapFrom(src => src.Documents));

        CreateMap<UpdateTicketCudRequestModel, UpdateTicketCudRequest>();
        CreateMap<UpdateTicketSubeRequestModel, UpdateTicketSubeRequest>();
        CreateMap<UpdateTicketParkingRequestModel, UpdateTicketParkingRequest>();

        CreateMap<ListTicketAgentRequestModel, ListTicketAgentRequest>();
        CreateMap<DocumentRequestModel, CreateTicketDocumentRequest>();

        CreateMap<AddDocumentRequestModel, AddDocumentRequest>();
        CreateMap<AddDocumentRequestModelList, AddDocumentRequestList>();
        CreateMap<SendMessageRequestModel, AddMessageRequest>();
        CreateMap<GetMessagesRequestModel, GetMessagesRequest>();
        CreateMap<ReassignTicketRequestModel, ReassignTicketRequest>();
        CreateMap<AddTemplateRequestModel, AddTemplateRequest>();
        CreateMap<UpdateTemplateRequestModel, UpdateTemplateRequest>();


    }

    private void RequestToDTO()
    {
        CreateMap<CreateTicketCudRequest, CreateTicketCudData>()
        .ForMember(dest => dest.Documents, opt => opt.MapFrom(src => src.Documents));

        CreateMap<CreateTicketSubeRequest, CreateTicketSubeData>()
        .ForMember(dest => dest.Documents, opt => opt.MapFrom(src => src.Documents));

        CreateMap<CreateTicketParkingRequest, CreateTicketParkingData>()
        .ForMember(dest => dest.Documents, opt => opt.MapFrom(src => src.Documents));

        CreateMap<UpdateTicketCudRequest, UpdateTicketCudData>();
        CreateMap<UpdateTicketSubeRequest, UpdateTicketSubeData>();
        CreateMap<UpdateTicketParkingRequest, UpdateTicketParkingData>();

        CreateMap<ListTicketAgentRequest, ListTicketFiltersDto>();


        CreateMap<CreateTicketDocumentRequest, DocumentData>();
        CreateMap<AddDocumentRequest, DocumentData>();
        CreateMap<UpdateDocumentStatusRequestModel, UpdateDocumentStatusData>();
        CreateMap<AddMessageRequest, ChatMessageData>();

        CreateMap<AddTemplateRequest, AddTemplateData>();
        CreateMap<UpdateTemplateRequest, UpdateTemplateData>();


    }

    private void DTOToEntity()
    {
        CreateMap<CreateTicketCudData, Ticket>()
        .ForMember(dest => dest.Documents, opt => opt.MapFrom(src => src.Documents));

        CreateMap<CreateTicketSubeData, Ticket>()
        .ForMember(dest => dest.Documents, opt => opt.MapFrom(src => src.Documents));

        CreateMap<CreateTicketParkingData, Ticket>()
        .ForMember(dest => dest.Documents, opt => opt.MapFrom(src => src.Documents));

        CreateMap<CreateTicketCudData, TicketCud>();
        CreateMap<CreateTicketSubeData, TicketSube>();
        CreateMap<CreateTicketParkingData, TicketParking>();

        CreateMap<UpdateTicketCudData, Ticket>()
        .ForMember(dest => dest.TicketStatusId, opt => opt.MapFrom(src => src.TicketStatusId));

        CreateMap<UpdateTicketCudData, TicketCud>()
            .ForMember(dest => dest.CertificateExpansionOptionsId, opt => opt.MapFrom(src => src.CertificateExpansionOptionsId))
            .ForMember(dest => dest.SignatureOptionId, opt => opt.MapFrom(src => src.SignatureOptionsId))
            .ForMember(dest => dest.Certificate, opt => opt.MapFrom(src => src.Certificate))
            .ForMember(dest => dest.ExpiredCertificate, opt => opt.MapFrom(src => src.ExpiredCertificate))
            .ForMember(dest => dest.LostCertificate, opt => opt.MapFrom(src => src.LostCertificate))
            .ForMember(dest => dest.HealthInsurance, opt => opt.MapFrom(src => src.HealthInsurance))
            .ForMember(dest => dest.PaySlip, opt => opt.MapFrom(src => src.PaySlip))
            .ForMember(dest => dest.DocumentComplete, opt => opt.MapFrom(src => src.DocumentComplete))
            .ForMember(dest => dest.MedicalCommitteDate, opt => opt.MapFrom(src => src.MedicalCommitteDate.HasValue
            ? DateTime.SpecifyKind(src.MedicalCommitteDate.Value, DateTimeKind.Utc)
            : (DateTime?)null));

        CreateMap<UpdateTicketSubeData, Ticket>()
        .ForMember(dest => dest.TicketStatusId, opt => opt.MapFrom(src => src.TicketStatusId));

        CreateMap<UpdateTicketSubeData, TicketSube>()
            .ForMember(dest => dest.CardPickupId, opt => opt.MapFrom(src => src.CardPickupLocationsOptionsId))
            .ForMember(dest => dest.CudCertificateNumber, opt => opt.MapFrom(src => src.CudCertificateNumber))
            .ForMember(dest => dest.CudExpirationDate, opt => opt.MapFrom(src => src.CudExpirationDate.HasValue
            ? DateTime.SpecifyKind(src.CudExpirationDate.Value, DateTimeKind.Utc)
            : (DateTime?)null));

        CreateMap<UpdateTicketParkingData, Ticket>()
        .ForMember(dest => dest.TicketStatusId, opt => opt.MapFrom(src => src.TicketStatusId));

        CreateMap<DocumentData, Document>();
        CreateMap<ChatMessageData, ChatMessage>();
        CreateMap<AddTemplateData, DocumentTemplate>();
        CreateMap<UpdateTemplateData, DocumentTemplate>();

    }
    #endregion

    #region Database To Response
    private void EntityToDTO()
    {
        CreateMap<Ticket, CreateTicketCudData>();
        CreateMap<Ticket, CreateTicketParkingData>();
        CreateMap<Ticket, CreateTicketSubeData>();

        CreateMap<TicketCud, GetTicketCudData>();
        CreateMap<TicketSube, GetTicketSubeData>();
        CreateMap<TicketParking, GetTicketParkingData>();

        CreateMap<Ticket, TicketData>();
        CreateMap<CardPickupLocationsOptions, CardPickupLocationsOptionsData>();

        CreateMap<Ticket, ListTicketData>();

        CreateMap<Document, DocumentData>();
        CreateMap<DocumentType, DocumentTypeData>();
        CreateMap<SignatureOption, SignatureOptionsData>();
        CreateMap<TicketStatus, TicketStatusData>();
        CreateMap<TicketType, TicketTypeData>();
        CreateMap<CertificateExpansionOptions, CertificateExpansionOptionsData>();

        CreateMap<ChatMessage, GetMessageData>()
                    .ForMember(dest => dest.Message, opt => opt.MapFrom(src => src.Message))
                    .ForMember(dest => dest.SentAt, opt => opt.MapFrom(src => src.SentAt));
    }

    private void DTOToResponse()
    {
        CreateMap<CreateTicketCudData, CreateTicketCudResponse>();
        CreateMap<CreateTicketSubeData, CreateTicketSubeResponse>();
        CreateMap<CreateTicketParkingData, CreateTicketParkingResponse>();
        CreateMap<DocumentData, AddDocumentResponse>();
        CreateMap<GetMessageData, GetMessagesResponse>();

        CreateMap<DocumentTemplate, ListTemplateData>();


    }
    #endregion
}
