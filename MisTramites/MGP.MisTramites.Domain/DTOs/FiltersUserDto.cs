namespace MGP.MisTramites.Domain.DTOs;
public class FiltersUserDto
{
    public Guid UserId { get; set; }
    public string TicketCode { get; set; }
    public int? TicketTypeId { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
}
