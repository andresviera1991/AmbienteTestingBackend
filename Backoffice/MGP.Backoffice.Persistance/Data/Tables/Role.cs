using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGP.Backoffice.Persistence.Data.Tables
{
    [Table("Role")]
    public class Role : IdentityRole<Guid>
    {
        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
