using MGP.Backoffice.Persistence.Data.Tables;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MGP.Backoffice.Persistance.Data.Tables
{
    public class MenuByAreaAndRole
    {

        [ForeignKey("Role")]
        public Guid RoleId { get; set; }

        public virtual Role Role { get; set; }


        [ForeignKey("Menu")]
        public int MenuId { get; set; }
        public virtual Menu Menu { get; set; }


        [ForeignKey("Area")]
        public int? AreaId { get; set; }

        public virtual Area Area { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

    }
}
