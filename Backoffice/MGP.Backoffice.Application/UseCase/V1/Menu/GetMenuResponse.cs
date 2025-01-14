using MGP.Backoffice.Domain.DTOs;

namespace MGP.Backoffice.Application.UseCase.V1.Menu
{
    public class GetMenuResponse
    {
        public List<MenuDto> Menus { get; set; }
    }
}
