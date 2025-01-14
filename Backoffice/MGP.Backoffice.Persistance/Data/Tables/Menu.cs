using System.ComponentModel.DataAnnotations;
using MGP.Backoffice.Persistance.Data.Tables.Base;

namespace MGP.Backoffice.Persistance.Data.Tables
{
    public class Menu : EntityBase
    {
        public int? ParentMenuId { get; set; }

        public virtual Menu ParentMenu { get; set; }

        public virtual ICollection<Menu> ChildMenus { get; set; }

        [Required]
        [StringLength(100)]
        public string Label { get; set; }

        [StringLength(100)]
        public string Icon { get; set; }

        [StringLength(255)]
        public string Url { get; set; }

        public int Order { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual ICollection<MenuByAreaAndRole> MenuByAreaAndRoles { get; set; }
    }
}
