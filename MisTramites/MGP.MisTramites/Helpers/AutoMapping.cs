using AutoMapper;
using MGP.Discapacidad.API.Controllers.V1.Ticket.Request;
using MGP.MisTramites.Application.UseCase.V1.Agent.GetTicket;
using MGP.MisTramites.Application.UseCase.V1.Agent.ListTickets;
using MGP.MisTramites.Application.UseCase.V1.User.GetTicket;
using MGP.MisTramites.Application.UseCase.V1.User.ListTickets;
using MGP.MisTramites.Client.DTOs.Request;
using MGP.MisTramites.Client.DTOs.Response.ListTicket;
using MGP.MisTramites.Domain.DTOs;
namespace MGP.MisTramites.API.Helpers;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        ModelToRequest();
        RequestToDTO();
        DTOToEntity();
        ModelToDTO();
        EntityToDTO();
        DTOToResponse();
    }

    #region Request To Database
    private void ModelToRequest()
    {
        CreateMap<GetTicketRequestModel, GetTicketUserRequest>();
        CreateMap<GetTicketRequestModel, GetTicketAgentRequest>();

        CreateMap<ListTicketAgentFiltersRequestModel, ListTicketAgentRequest>();
        CreateMap<ListTicketUserFiltersRequestModel, ListTicketUserRequest>();


    }

    private void ModelToDTO()
    {
        CreateMap<ListTicketAgentRequest, FiltersAgentRequestModel>();
        CreateMap<ListTicketUserRequest, FiltersUserDto>();

    }

    private void RequestToDTO()
    {

        //Metodo a realizar

    }

    private void DTOToEntity()
    {
        //Metodo a realizar

    }
    #endregion

    #region Database To Response
    private void EntityToDTO()
    {
        //Metodo a realizar

    }
    #endregion

    #region DTO To Response
    private void DTOToResponse()
    {

    }
    #endregion
}
