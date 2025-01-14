using AutoMapper;
using MGP.Backoffice.Persistance.Data.Tables;
using MGP.Backoffice.Persistance.DTOs;
using MGP.Backoffice.Application.UseCase.V1.GetAgent;
using MGP.Backoffice.API.Controllers.V1.Auth.Request.NewToken;
using MGP.Backoffice.Api.Controllers.Auth.Request;
using MGP.Backoffice.Api.Controllers.Auth;
using MGP.Backoffice.Domain.DTOs;
using MGP.Backoffice.Persistence.Data.Tables;
using MGP.Backoffice.Api.Controllers.Agent.Request;
using MGP.Authentication.API.Controllers.V1.Password.Request;
using MGP.Backoffice.Application.UseCase.V1.Menu;
using MGP.Backoffice.Application.UseCase.V1.AddAgentLeave;
using MGP.Backoffice.Application.UseCase.V1.GetAgentLeave;
using MGP.Backoffice.Application.UseCase.V1.UpdateAgentLeave;
using MGP.Backoffice.Application.UseCase.V1.Auth.Register;
using MGP.Backoffice.Application.UseCase.V1.Auth.NewTokens;
using MGP.Backoffice.Application.UseCase.V1.Auth.Login;
using MGP.Backoffice.Application.UseCase.V1.Auth.ChangePassword;
using MGP.Backoffice.Application.UseCase.V1.UpdateAgent;
using MGP.Backoffice.Api.Controllers.Agent.Request.Update;
using MGP.Backoffice.Application.UseCase.V1.NextAvailableAgent;
using MGP.Backoffice.Application.UseCase.V1.ListAgents.ListByFilters;

namespace MGP.Backoffice.Api.Helper;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        ModelToRequest();
        RequestToDTO();
        DTOToEntity();
        EntityToDto();
        EntityToDTO();
        DTOToResponse();
    }

    private void ModelToRequest()
    {
        CreateMap<ListAgentByFiltersRequestModel, ListAgentByFiltersRequest>();
        CreateMap<RegisterRequestModel, RegisterRequest>();
        CreateMap<NewTokensRequestModel, NewTokensRequest>();
        CreateMap<LoginRequestModel, LoginRequest>();
        CreateMap<ChangePasswordRequestModel, ChangePasswordRequest>();
        CreateMap<AddAgentLeaveRequestModel, AddAgentLeaveRequest>();
        CreateMap<UpdateAgentLeaveRequestModel, UpdateAgentLeaveRequest>();
        CreateMap<UpdateAgentRequestModel, UpdateAgentRequest>();
        CreateMap<TicketTypeRequestModel, TicketTypeData>();
        CreateMap<NextAvailableAgentRequestModel, NextAvailableAgentRequest>();
        CreateMap<ListAgentByFiltersRequestModel, ListAgentByFiltersRequest>();
    }

    private void RequestToDTO()
    {
        CreateMap<LoginRequest, LoginData>();
        CreateMap<RegisterRequest, RegisterRequestData>();
        CreateMap<ChangePasswordRequest, ChangePasswordData>();
        CreateMap<AddAgentLeaveRequest, AgentLeaveData>();
        CreateMap<GetMenuRequest, AreaRolData>();
        CreateMap<UpdateAgentLeaveRequest, AgentLeaveDataToUpdate>();
        CreateMap<UpdateAgentRequest, UpdateAgentData>();
        CreateMap<ListAgentByFiltersRequest, ListAgentByFiltersData>();
    }

    private void DTOToEntity()
    {
        CreateMap<RegisterRequestData, User>();
        CreateMap<AgentLeaveData, AgentLeave>();
        CreateMap<AgentLeaveDataToUpdate, AgentLeave>();
        CreateMap<UpdateAgentData, User>();
        CreateMap<TicketTypeData, TicketType>();
    }

    private void EntityToDto()
    {
        CreateMap<Menu, MenuDto>();
        CreateMap<AgentLeave, AgentLeaveData>();
        CreateMap<AgentLeave, AgentLeaveDataToUpdate>();
    }

    private void EntityToDTO()
    {
        CreateMap<User, UserData>();
        CreateMap<User, FullNameData>();
        CreateMap<Area, AreaData>();
        CreateMap<Role, RoleData>();
        CreateMap<TicketType, TicketTypeData>();
        CreateMap<UserStatus, UserStatusData>();

    }

    private void DTOToResponse()
    {
        CreateMap<UserData, ListAgentByFiltersResponse>();
        CreateMap<UserData, GetAgentResponse>();
        CreateMap<AgentLeaveData, AddAgentLeaveResponse>();
        CreateMap<AgentLeaveData, GetAgentLeaveResponse>();
        CreateMap<AgentLeaveData, UpdateAgentLeaveResponse>();
        CreateMap<UserData, NextAvailableAgentResponse>();
    }
}