using MGP.Discapacidad.CrossCutting.Enum;
using MGP.Discapacidad.Persistance.Data.Tables;
using MGP.Discapacidad.Persistance.DTOs.Ticket;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Persistance.Interface;
public interface ITicketRepository
{

    #region CREATE TICKET METHODS
    Task<Ticket> CreateTicketCudAsync(CreateTicketCudData ticketCudData);
    Task<Ticket> CreateTicketSubeAsync(CreateTicketSubeData ticketSubeData);
    Task<Ticket> CreateTicketParkingAsync(CreateTicketParkingData ticketParkingData);
    #endregion

    #region GET TICKET METHODS
    Task<TicketCud> GetTicketCudUserAsync(Guid userId, Guid? ticketId, string ticketCode);
    Task<TicketSube> GetTicketSubeUserAsync(Guid userId, Guid? ticketId, string ticketCode);
    Task<TicketParking> GetTicketParkingUserAsync(Guid userId, Guid? ticketId, string ticketCode);

    #region GET TICKET METHOD (AGENT)

    Task<TicketCud> GetTicketCudAgentAsync(Guid? ticketId, string ticketCode);
    Task<TicketSube> GetTicketSubeAgentAsync(Guid? ticketId, string ticketCode);
    Task<TicketParking> GetTicketParkingAgentAsync(Guid? ticketId, string ticketCode);

    #endregion
    #endregion

    #region LIST TICKET METHODS
    Task<Ticket[]> ListTicketsAsync(Guid userId);
    Task<Ticket[]> ListTicketsAsync(Guid? agentId, int? ticketTypeId, int? ticketStatusId, int pageSize, int pageNumber, List<Guid> userIds, string ticketCode);

    #endregion

    #region UPDATE TICKET METHODS
    Task UpdateAllTicketStatusesAsync(Guid userId, int ticketStatusId);
    Task UpdateAgentAssignedAsync(Guid agentId, List<string> backupAgentList);
    Task<TicketCud> UpdateTicketCudAsync(UpdateTicketCudData updateTicketCudData);
    Task<TicketSube> UpdateTicketSubeAsync(UpdateTicketSubeData updateTicketSubeData);
    Task<TicketParking> UpdateTicketParkingAsync(UpdateTicketParkingData updateTicketParkingData);
    #endregion

    Task<bool> VerifyUserAsync(Guid userId, Guid ticketId);
    Task<bool> TicketOpenExistAsync(Guid userId, TicketTypeEnum ticketType);
    Task CancelTicket(Guid userId, Guid ticketId);
    Task<bool> TicketExistAsync(Guid ticketId);
    Task ReassignTicketAsync(Guid ticketId, Guid agentId);
    Task<List<CountTicketByAgentData>> CountTicketByAgentAsync();
    Task<bool> TicketTypeExistsAsync(int ticketTypeId);
    Task<List<Ticket>> ListTicketAssigned(Guid agentId);
    Task SaveChangesAsync(List<Ticket> tickets);
    Task<int> CountTicketsByFiltersAsync(Guid? agentId, int? ticketTypeId, int? ticketStatusId, int pageSize, int pageNumber, List<Guid> userIds, string ticketCode);
}
