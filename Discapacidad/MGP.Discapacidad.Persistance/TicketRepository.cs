using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.Persistance.Data.Tables;
using MGP.Discapacidad.CrossCutting.Enum;
using MGP.Discapacidad.Persistance.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MGP.Discapacidad.Persistance.DTOs.Ticket;
using System.Collections.Generic;
using MGP.Discapacidad.Persistance.DTOs.Document;
using MGP.Discapacidad.Persistance.DTOs.Catalog;
namespace MGP.Discapacidad.Persistance;

public class TicketRepository : ITicketRepository
{
    private readonly MyDbContext _dbContext;
    private readonly IMapper _mapper;

    public TicketRepository(MyDbContext dbContext,
                            IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    #region CREATE TICKET 
    public async Task<Ticket> CreateTicketCudAsync(CreateTicketCudData ticketCudData)
    {
        DateTime adjustedUtcNow = UtcDateTime();

        Ticket ticket = _mapper.Map<Ticket>(ticketCudData);
        ticket.Id = Guid.NewGuid();
        ticket.TicketTypeId = (int)TicketTypeEnum.CUD;
        ticket.TicketStatusId = (int)TicketStatusEnum.NEW;
        ticket.CreationDate = adjustedUtcNow;
        ticket.TicketCode = await GenerateTicketCode();

        TicketCud ticketCud = _mapper.Map<TicketCud>(ticketCudData);
        ticketCud.Ticket = ticket;
        ticketCud.CreationDate = adjustedUtcNow;

        AddDocumentsAsync(adjustedUtcNow, ticket);

        _dbContext.Set<TicketCud>().Add(ticketCud);
        await _dbContext.SaveChangesAsync();

        return ticket;
    }

    public async Task<Ticket> CreateTicketSubeAsync(CreateTicketSubeData ticketSubeData)
    {
        await VerifyCardPickupOption(ticketSubeData.CardPickupId);

        DateTime adjustedUtcNow = UtcDateTime();

        Ticket ticket = _mapper.Map<Ticket>(ticketSubeData);

        ticket.Id = Guid.NewGuid();
        ticket.TicketTypeId = (int)TicketTypeEnum.SUBE;
        ticket.TicketStatusId = (int)TicketStatusEnum.NEW;

        ticket.CreationDate = adjustedUtcNow;
        ticket.TicketCode = await GenerateTicketCode();

        AddDocumentsAsync(adjustedUtcNow, ticket);

        TicketSube ticketSube = _mapper.Map<TicketSube>(ticketSubeData);
        ticketSube.Ticket = ticket;
        ticketSube.CreationDate = adjustedUtcNow;

        _dbContext.Set<TicketSube>().Add(ticketSube);
        await _dbContext.SaveChangesAsync();

        return ticket;
    }

    private async Task VerifyCardPickupOption(int cardPickupId)
    {
        var exists = await _dbContext.Set<CardPickupLocationsOptions>().AnyAsync(c => c.Id == cardPickupId);

        if (!exists)
        {
            throw new CardPickupLocationNotExistsException();
        }
    }

    public async Task<Ticket> CreateTicketParkingAsync(CreateTicketParkingData ticketParkingData)
    {
        DateTime adjustedUtcNow = UtcDateTime();

        Ticket ticket = _mapper.Map<Ticket>(ticketParkingData);
        ticket.Id = Guid.NewGuid();
        ticket.TicketTypeId = (int)TicketTypeEnum.PARKING;
        ticket.TicketStatusId = (int)TicketStatusEnum.NEW;
        ticket.CreationDate = adjustedUtcNow;
        ticket.TicketCode = await GenerateTicketCode();

        AddDocumentsAsync(adjustedUtcNow, ticket);

        TicketParking ticketParking = _mapper.Map<TicketParking>(ticketParkingData);
        ticketParking.Ticket = ticket;
        ticketParking.CreationDate = adjustedUtcNow;

        _dbContext.Set<TicketParking>().Add(ticketParking);
        await _dbContext.SaveChangesAsync();
        return ticket;

    }

    #endregion

    #region GET TICKETS METHODS

    public async Task<TicketCud> GetTicketCudUserAsync(Guid userId, Guid? ticketId, string ticketCode)
    {
        return await _dbContext.Set<TicketCud>()
            .Include(t => t.Ticket)
                .ThenInclude(t => t.Documents.Where(d => d.DocumentStatusId != (int)DocumentStatusEnum.DELETED))
                .ThenInclude(d => d.DocumentStatus)
            .Include(t => t.Ticket.Documents)
                .ThenInclude(d => d.DocumentType)
            .Include(t => t.Ticket.TicketStatus)
            .Include(t => t.Ticket.TicketType)
            .Include(t => t.SignatureOption)
            .Include(t => t.CertificateExpansionOptions)
            .Where(t =>
                t.Ticket.UserId == userId &&
                t.Ticket.TicketTypeId == (int)TicketTypeEnum.CUD &&
                (ticketId != Guid.Empty ? t.Ticket.Id == ticketId.Value : t.Ticket.TicketCode == ticketCode)).SingleOrDefaultAsync() ?? throw new TicketNotFoundException();

    }
    public async Task<TicketSube> GetTicketSubeUserAsync(Guid userId, Guid? ticketId, string ticketCode)
    {
        return await _dbContext.Set<TicketSube>()
             .Include(t => t.Ticket)
                 .ThenInclude(t => t.Documents
                     .Where(d => d.DocumentStatusId != (int)DocumentStatusEnum.DELETED))
                 .ThenInclude(d => d.DocumentStatus)
             .Include(t => t.Ticket)
                 .ThenInclude(t => t.Documents)
                 .ThenInclude(d => d.DocumentType)
             .Include(t => t.CardPickupLocationsOptions)
             .Include(t => t.Ticket.TicketStatus)
             .Include(t => t.Ticket.TicketType)
             .Where(t => t.Ticket.UserId == userId &&
              t.Ticket.TicketTypeId == (int)TicketTypeEnum.SUBE &&
              (ticketId != Guid.Empty ? t.Ticket.Id == ticketId.Value : t.Ticket.TicketCode == ticketCode)).SingleOrDefaultAsync() ?? throw new TicketNotFoundException();

    }
    public async Task<TicketParking> GetTicketParkingUserAsync(Guid userId, Guid? ticketId, string ticketCode)
    {
        return await _dbContext.Set<TicketParking>()
            .Include(t => t.Ticket)
                .ThenInclude(t => t.Documents
                    .Where(d => d.DocumentStatusId != (int)DocumentStatusEnum.DELETED))
                .ThenInclude(d => d.DocumentStatus)
            .Include(t => t.Ticket)
                .ThenInclude(t => t.Documents)
                .ThenInclude(d => d.DocumentType)
                .Include(t => t.Ticket.TicketStatus)
                .Include(t => t.Ticket.TicketType)
                .Where(t => t.Ticket.UserId == userId &&
                t.Ticket.TicketTypeId == (int)TicketTypeEnum.PARKING &&
                (ticketId != Guid.Empty ? t.Ticket.Id == ticketId.Value : t.Ticket.TicketCode == ticketCode)).SingleOrDefaultAsync() ?? throw new TicketNotFoundException();
    }

    #region GET TICKET METHODS (AGENT)

    public async Task<TicketCud> GetTicketCudAgentAsync(Guid? ticketId, string ticketCode)
    {
        return await _dbContext.Set<TicketCud>()
                    .Include(t => t.Ticket)
                        .ThenInclude(t => t.Documents.Where(d => d.DocumentStatusId != (int)DocumentStatusEnum.DELETED))
                        .ThenInclude(d => d.DocumentStatus)
                    .Include(t => t.Ticket.Documents)
                        .ThenInclude(d => d.DocumentType)
                    .Include(t => t.Ticket.TicketStatus)
                    .Include(t => t.Ticket.TicketType)
                    .Include(t => t.SignatureOption)
                    .Include(t => t.CertificateExpansionOptions)
                    .Where(t =>
                        t.Ticket.TicketTypeId == (int)TicketTypeEnum.CUD &&
                        (ticketId != Guid.Empty ? t.Ticket.Id == ticketId.Value : t.Ticket.TicketCode == ticketCode)).SingleOrDefaultAsync() ?? throw new TicketNotFoundException();

    }
    public async Task<TicketSube> GetTicketSubeAgentAsync(Guid? ticketId, string ticketCode)
    {
        return await _dbContext.Set<TicketSube>()
                    .Include(t => t.Ticket)
                        .ThenInclude(t => t.Documents
                            .Where(d => d.DocumentStatusId != (int)DocumentStatusEnum.DELETED))
                        .ThenInclude(d => d.DocumentStatus)
                    .Include(t => t.Ticket)
                        .ThenInclude(t => t.Documents)
                        .ThenInclude(d => d.DocumentType)
                        .Include(t => t.Ticket.TicketStatus)
                        .Include(t => t.Ticket.TicketType)
                    .Include(t => t.CardPickupLocationsOptions)
                    .Where(t => t.Ticket.TicketTypeId == (int)TicketTypeEnum.SUBE &&
                     (ticketId != Guid.Empty ? t.Ticket.Id == ticketId.Value : t.Ticket.TicketCode == ticketCode)).SingleOrDefaultAsync() ?? throw new TicketNotFoundException();

    }
    public async Task<TicketParking> GetTicketParkingAgentAsync(Guid? ticketId, string ticketCode)
    {
        return await _dbContext.Set<TicketParking>()
                    .Include(t => t.Ticket)
                        .ThenInclude(t => t.Documents
                            .Where(d => d.DocumentStatusId != (int)DocumentStatusEnum.DELETED))
                        .ThenInclude(d => d.DocumentStatus)
                    .Include(t => t.Ticket)
                        .ThenInclude(t => t.Documents)
                        .ThenInclude(d => d.DocumentType)
                        .Include(t => t.Ticket.TicketStatus)
                        .Include(t => t.Ticket.TicketType)
                        .Where(t => t.Ticket.TicketTypeId == (int)TicketTypeEnum.PARKING &&
                        (ticketId != Guid.Empty ? t.Ticket.Id == ticketId.Value : t.Ticket.TicketCode == ticketCode)).SingleOrDefaultAsync() ?? throw new TicketNotFoundException();

    }
    public async Task<List<CountTicketByAgentData>> CountTicketByAgentAsync()
    {
        var finalizedStatuses = new[] { 6, 7 };
        var oneMonthAgo = DateTime.UtcNow.AddMonths(-1);

        var groupedTickets = await _dbContext.Set<Ticket>()
            .Include(t => t.TicketStatus)
            .Where(t => !finalizedStatuses.Contains(t.TicketStatusId) || t.CreationDate >= oneMonthAgo)
            .GroupBy(t => new
            {
                t.AgentId,
                TicketStatusId = finalizedStatuses.Contains(t.TicketStatusId) ? 0 : t.TicketStatusId, // Agrupa "Finalizados" como una sola categoría
                TicketStatusName = finalizedStatuses.Contains(t.TicketStatusId) ? "Finalizados" : t.TicketStatus.Name
            })
            .Select(g => new
            {
                g.Key.AgentId,
                g.Key.TicketStatusId,
                g.Key.TicketStatusName,
                Quantity = g.Count()
            })
            .ToListAsync();

        var countTicketStatus = groupedTickets
            .GroupBy(g => g.AgentId)
            .Select(agentGroup => new CountTicketByAgentData
            {
                AgentId = agentGroup.Key.Value,
                TicketStatusQuantity = agentGroup.Select(ticket => new TicketStatusQuantityData
                {
                    Quantity = ticket.Quantity,
                    TicketStatus = new TicketStatusData
                    {
                        Id = ticket.TicketStatusId,
                        Name = ticket.TicketStatusName
                    }
                }).ToList()
            })
            .ToList();

        return countTicketStatus;
    }

    #endregion

    #endregion

    #region LIST TICKETS METHOD

    public async Task<Ticket[]> ListTicketsAsync(Guid userId)
    {
        return await _dbContext.Set<Ticket>()
            .AsTracking()
            .Where(t => t.UserId == userId)
            .Include(t => t.TicketStatus)
            .Include(t => t.TicketType)
            .ToArrayAsync();
    }

    public async Task<Ticket[]> ListTicketsAsync(Guid? agentId, int? ticketTypeId, int? ticketStatusId, int pageSize, int pageNumber, List<Guid> userIds, string ticketCode)

    {
        IQueryable<Ticket> query = _dbContext.Set<Ticket>().Include(t => t.TicketType).Include(t => t.TicketStatus);

        if (agentId != null)
        {
            query = query.Where(t => t.AssignedAgentId == agentId);
        }

        if (!string.IsNullOrEmpty(ticketCode))
        {
            query = query.Where(t => t.TicketCode == ticketCode);
        }

        if (ticketTypeId != 0 && ticketTypeId != null)
        {
            query = query.Where(t => t.TicketTypeId == ticketTypeId);
        }

        if (ticketStatusId != 0 && ticketStatusId != null)
        {
            query = query.Where(t => t.TicketStatusId == ticketStatusId);
        }
        if (userIds.Count != 0)
        {
            query = query.Where(t => userIds.Contains(t.UserId));
        }

        int skip = (pageNumber - 1) * pageSize;

        return await query
            .OrderByDescending(x => x.CreationDate) // Ordena por fecha de creación en orden ascendente
            .Skip(skip)
            .Take(pageSize)
            .ToArrayAsync();
    }

    public async Task<int> CountTicketsByFiltersAsync(Guid? agentId, int? ticketTypeId, int? ticketStatusId, int pageSize, int pageNumber, List<Guid> userIds, string ticketCode)
    {
        IQueryable<Ticket> query = _dbContext.Set<Ticket>().Include(t => t.TicketType).Include(t => t.TicketStatus);

        if (agentId != null)
        {
            query = query.Where(t => t.AssignedAgentId == agentId);
        }

        if (!string.IsNullOrEmpty(ticketCode))
        {
            query = query.Where(t => t.TicketCode == ticketCode);
        }

        if (ticketTypeId != 0 && ticketTypeId != null)
        {
            query = query.Where(t => t.TicketTypeId == ticketTypeId);
        }

        if (ticketStatusId != 0 && ticketStatusId != null)
        {
            query = query.Where(t => t.TicketStatusId == ticketStatusId);
        }
        if (userIds.Count != 0)
        {
            query = query.Where(t => userIds.Contains(t.UserId));
        }

        return await query.CountAsync();
    }

    #endregion

    #region UPDATE TICKET METHODS

    public async Task UpdateAgentAssignedAsync(Guid agentId, List<string> backupAgentList)
    {
        var ticketsToUpdate = await GetTicketsToUpdateAsync(agentId);

        if (backupAgentList.Count == 0)
            return;

        if (ShouldReassignToSameAgent(agentId, backupAgentList))
        {
            ReassignTicketsToSameAgent(ticketsToUpdate, agentId);
        }
        else
        {
            ReassignTicketsToBackupAgents(ticketsToUpdate, agentId, backupAgentList);
        }

        await _dbContext.SaveChangesAsync();
    }

    private async Task<List<Ticket>> GetTicketsToUpdateAsync(Guid agentId)
    {
        return await _dbContext.Set<Ticket>()
            .Where(t => t.AgentId == agentId || t.AssignedAgentId == agentId)
            .ToListAsync();
    }

    private static bool ShouldReassignToSameAgent(Guid agentId, List<string> backupAgentList)
    {
        return backupAgentList.Count == 1 && backupAgentList.Contains(agentId.ToString());
    }

    private static void ReassignTicketsToSameAgent(List<Ticket> tickets, Guid agentId)
    {
        foreach (var ticket in tickets)
        {
            if (ticket.AgentId == agentId || ticket.AssignedAgentId == agentId)
            {
                ticket.AssignedAgentId = agentId;
            }
        }
    }

    private static void ReassignTicketsToBackupAgents(List<Ticket> tickets, Guid agentId, List<string> backupAgentList)
    {
        int agentIndex = 0;
        int backupAgentCount = backupAgentList.Count;

        foreach (var ticket in tickets)
        {
            if (ticket.AgentId == agentId || ticket.AssignedAgentId == agentId)
            {
                ticket.AssignedAgentId = Guid.Parse(backupAgentList[agentIndex]);
                agentIndex = (agentIndex + 1) % backupAgentCount;
            }
        }
    }

    public async Task UpdateAllTicketStatusesAsync(Guid userId, int ticketStatusId)
    {
        var tickets = await _dbContext.Set<Ticket>()
            .Where(t => t.UserId == userId)
            .ToListAsync();

        if (tickets.Count == 0)
        {
            throw new TicketNotFoundException();
        }

        foreach (var ticket in tickets)
        {
            ticket.TicketStatusId = ticketStatusId;
            ticket.ModifiedDate = DateTime.UtcNow;
        }

        await _dbContext.SaveChangesAsync();
    }

    public async Task CancelTicket(Guid userId, Guid ticketId)
    {
        Ticket ticket = await _dbContext.Set<Ticket>().Where(t => t.UserId == userId && t.Id == ticketId).SingleOrDefaultAsync() ?? throw new TicketNotFoundException();
        ticket.TicketStatusId = (int)TicketStatusEnum.CANCELED;
        await _dbContext.SaveChangesAsync();
    }

    public async Task<TicketCud> UpdateTicketCudAsync(UpdateTicketCudData updateTicketCudData)
    {
        await TicketStatusExists(updateTicketCudData.TicketStatusId);

        if (!updateTicketCudData.Certificate)
        {
            updateTicketCudData.CertificateExpansionOptionsId = 1;
            updateTicketCudData.LostCertificate = false;
            updateTicketCudData.ExpiredCertificate = false;
        }
        var ticketCud = await _dbContext.Set<TicketCud>()
                                        .Include(t => t.Ticket)
                                        .Include(t => t.Ticket.Documents)
                                        .FirstOrDefaultAsync(t => t.Id == updateTicketCudData.TicketId)
                                         ?? throw new TicketNotFoundException();


        _mapper.Map(updateTicketCudData, ticketCud);
        _mapper.Map(updateTicketCudData, ticketCud.Ticket);

        await UpdatedDocumentStatus(updateTicketCudData.UpdateDocumentStatus, ticketCud.Ticket.Documents);

        var modifiedDate = DateTime.UtcNow.AddHours(-3);
        ticketCud.ModifiedDate = modifiedDate;
        ticketCud.Ticket.ModifiedDate = modifiedDate;
        await _dbContext.SaveChangesAsync();
        return ticketCud;
    }

    public async Task<TicketSube> UpdateTicketSubeAsync(UpdateTicketSubeData updateTicketSubeData)
    {

        await TicketStatusExists(updateTicketSubeData.TicketStatusId);

        var ticketSube = await _dbContext.Set<TicketSube>()
                                         .Include(t => t.Ticket)
                                         .Include(t => t.Ticket.Documents)
                                         .FirstOrDefaultAsync(t => t.Id == updateTicketSubeData.TicketId)
                                          ?? throw new TicketNotFoundException();

        _mapper.Map(updateTicketSubeData, ticketSube);
        _mapper.Map(updateTicketSubeData, ticketSube.Ticket);

        await UpdatedDocumentStatus(updateTicketSubeData.UpdateDocumentStatus, ticketSube.Ticket.Documents);

        var modifiedDate = DateTime.UtcNow.AddHours(-3);
        ticketSube.ModifiedDate = modifiedDate;
        ticketSube.Ticket.ModifiedDate = modifiedDate;
        await _dbContext.SaveChangesAsync();
        return ticketSube;

    }

    public async Task<TicketParking> UpdateTicketParkingAsync(UpdateTicketParkingData updateTicketParkingData)
    {

        await TicketStatusExists(updateTicketParkingData.TicketStatusId);

        var ticketParking = await _dbContext.Set<TicketParking>()
                                                 .Include(t => t.Ticket)
                                                 .Include(t => t.Ticket.Documents)
                                                 .FirstOrDefaultAsync(t => t.Id == updateTicketParkingData.TicketId)
                                                  ?? throw new TicketNotFoundException();

        _mapper.Map(updateTicketParkingData, ticketParking.Ticket);

        await UpdatedDocumentStatus(updateTicketParkingData.UpdateDocumentStatus, ticketParking.Ticket.Documents);

        var modifiedDate = DateTime.UtcNow.AddHours(-3);
        ticketParking.ModifiedDate = modifiedDate;
        ticketParking.Ticket.ModifiedDate = modifiedDate;
        await _dbContext.SaveChangesAsync();
        return ticketParking;

    }

    private async Task UpdatedDocumentStatus(List<UpdateDocumentStatusData> updateTicketParkingData, List<Document> documents)
    {
        foreach (Document document in documents)
        {
            foreach (UpdateDocumentStatusData updateDocumentStatusData in updateTicketParkingData)
            {
                await VerifyDocumentStatus(updateDocumentStatusData.DocumentStatusId);

                if (document.Id == updateDocumentStatusData.DocumentId)
                {
                    document.DocumentStatusId = updateDocumentStatusData.DocumentStatusId;
                }
            }
        }
    }

    private async Task VerifyDocumentStatus(int documentStatusId)
    {
        var exists = await _dbContext.Set<DocumentStatus>().AnyAsync(d => d.Id == documentStatusId);
        if (!exists) { throw new DocumentStatusNotFoundException(); }
    }

    private async Task TicketStatusExists(int ticketStatusId)
    {
        var exist = await _dbContext.Set<TicketStatus>().AnyAsync(t => t.Id == ticketStatusId);

        if (!exist) { throw new TicketStatusNotFoundException(); }
    }

    public async Task ReassignTicketAsync(Guid ticketId, Guid agentId)
    {
        var ticket = await _dbContext.Set<Ticket>().Where(t => t.Id == ticketId).FirstOrDefaultAsync() ?? throw new TicketNotFoundException();
        ticket.AgentId = agentId;
        ticket.AssignedAgentId = agentId;
        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<Ticket>> ListTicketAssigned(Guid agentId)
    {
        return await _dbContext.Set<Ticket>().Where(t => t.AssignedAgentId == agentId).Include(t => t.TicketType).ToListAsync();
    }
    #endregion

    #region VALIDATE METHODS
    public async Task<bool> TicketOpenExistAsync(Guid userId, TicketTypeEnum ticketType)
    {
        var excludedStatuses = new[]
        {
        (int)TicketStatusEnum.CANCELED,
        (int)TicketStatusEnum.CLOSED_DENIED,
        (int)TicketStatusEnum.CLOSED_DUE_TO_NO_RESPONSE,
        (int)TicketStatusEnum.CLOSED_GRANTED
    };

        var exists = await _dbContext.Set<Ticket>()
            .AnyAsync(t => t.UserId == userId &&
                           t.TicketTypeId == (int)ticketType &&
                           !excludedStatuses.Contains(t.TicketStatusId));

        return exists;
    }

    public async Task<bool> VerifyUserAsync(Guid userId, Guid ticketId)
    {
        return await _dbContext.Set<Ticket>().AnyAsync(t => t.Id == ticketId && t.UserId == userId);
    }

    public Task<bool> TicketExistAsync(Guid ticketId)
    {
        return _dbContext.Set<Ticket>().AnyAsync(ticket => ticket.Id == ticketId);
    }

    public Task<bool> TicketTypeExistsAsync(int ticketTypeId)
    {
        return _dbContext.Set<TicketType>().AnyAsync(t => t.Id == ticketTypeId);
    }

    public async Task SaveChangesAsync(List<Ticket> tickets)
    {
        await _dbContext.SaveChangesAsync();
    }


    #endregion

    #region PRIVATE METHODS
    private async Task<string> GenerateTicketCode()
    {
        var lastTicket = await _dbContext.Set<Ticket>()
                    .OrderByDescending(t => t.TicketCode)
                    .FirstOrDefaultAsync();

        int newTicketNumber = lastTicket != null ? int.Parse(lastTicket.TicketCode.Split('-')[2]) + 1 : 1;

        string ticketCode = $"DS-DIS-{newTicketNumber}";
        return ticketCode;
    }
    private static DateTime UtcDateTime()
    {
        DateTime adjustedUtcNow = DateTime.UtcNow.AddHours(-3);  
        return DateTime.SpecifyKind(adjustedUtcNow, DateTimeKind.Utc);  
    }
    private static void AddDocumentsAsync(DateTime adjustedUtcNow, Ticket ticket)
    {
        foreach (var document in ticket.Documents)
        {
            document.CreationDate = adjustedUtcNow;
            document.DocumentStatusId = (int)DocumentStatusEnum.PENDING_VALIDATION;
        }
    }

    #endregion
}