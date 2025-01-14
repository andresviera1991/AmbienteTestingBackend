namespace MGP.MisTramites.Client.DTOs.Request;

public class FiltersAgentRequestModel
{
    public List<Guid> UserIds { get; set; }
    public string ServiceName { get; set; }
    public string FullName { get; set; }
    public string DocumentNumber { get; set; }
    public string TicketCode { get; set; }
    public int? TicketTypeId { get; set; }
    public int? TicketStatusId { get; set; }
    public bool AssignedToMe { get; set; }
    public Guid? AgentId { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
}