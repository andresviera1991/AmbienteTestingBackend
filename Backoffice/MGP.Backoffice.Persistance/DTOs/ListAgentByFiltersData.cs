namespace MGP.Backoffice.Persistance.DTOs;

public class ListAgentByFiltersData
{
    public string Role { get; set; }
    public string Area { get; set; }
    public string EmployeeNumber { get; set; }
    public string FullName { get; set; }
    public string DocumentNumber { get; set; }
    public int? UserStatusId { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
}
