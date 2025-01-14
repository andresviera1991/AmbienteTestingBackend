using MGP.Discapacidad.Persistance.DTOs.Ticket;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Domain.interfaces;

public interface ITicketService
{
    #region Create Tickets Method
    Task<CreateTicketCudData> CreateTicketCudAsync(CreateTicketCudData ticketCudData);
    Task<CreateTicketSubeData> CreateTicketSubeAsync(CreateTicketSubeData ticketSubeData);
    Task<CreateTicketParkingData> CreateTicketParkingAsync(CreateTicketParkingData ticketParkingData);
    #endregion

    #region GET TICKETS METHODS
    Task<GetTicketCudData> GetTicketCudUserAsync(Guid userId, Guid? ticketId, string ticketCode);
    Task<GetTicketSubeData> GetTicketSubeUserAsync(Guid userId, Guid? ticketId, string ticketCode);
    Task<GetTicketParkingData> GetTicketParkingUserAsync(Guid userId, Guid? ticketId, string ticketCode);

    #region GET TICKETS METHOD AGENT
    Task<GetTicketCudData> GetTicketCudAgentAsync(Guid ticketId, string ticketCode);
    Task<GetTicketSubeData> GetTicketSubeAgentAsync(Guid ticketId, string ticketCode);
    Task<GetTicketParkingData> GetTicketParkingAgentAsync(Guid ticketId, string ticketCode);
    #endregion
    #endregion

    #region LIST TICKETS METHOD
    Task<ListTicketData[]> ListTicketsUserAsync(Guid userId);
    Task<ListTicketData[]> ListTicketAgentAsync(ListTicketFiltersDto listTicketFiltersDto);

    #endregion

    #region UPDATE METHODS
    Task UpdateAllTicketStatusesAsync(Guid userId, int ticketStatusId);
    Task UpdateAgentAssignedAsync(Guid agentId, List<string> backupAgentList);
    Task CancelTicketAsync(Guid userId, Guid ticketId);
    Task UpdateTicketCudAsync(UpdateTicketCudData updateTicketCudData);
    Task UpdateTicketSubeAsync(UpdateTicketSubeData updateTicketSubeData);
    Task UpdateTicketParkingAsync(UpdateTicketParkingData updateTicketParkingData);
    Task<bool> TicketExitsAsync(Guid ticketId);
    Task ReassignTicketAsync(Guid agentId);
    Task ReassignTicketAsync(Guid ticketId, Guid agentId, Guid supervisorId);
    Task<List<CountTicketByAgentData>> CountTicketByAgentAsync();
    Task<int> CountTicketsByfilterAsync(ListTicketFiltersDto listTicketFiltersDto);

    #endregion
}
