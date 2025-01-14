namespace MGP.Backoffice.Domain.DTOs;

public class MenuDto
{
    public int Id { get; set; }
    public string Label { get; set; }
    public string Icon { get; set; }
    public string Url { get; set; }
    public int Order { get; set; }
    public bool IsActive { get; set; }
    public List<MenuDto> ChildMenus { get; set; }
}
