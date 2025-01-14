using MGP.Backoffice.Persistance.Data.Tables;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGP.Backoffice.Persistence.Data.Tables
{
    [Table("User")]
    public class User : IdentityUser<Guid>
    {
        public string EmployeeNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string DocumentNumber { get; set; }

        public int UserStatusId { get; set; }

        [ForeignKey("UserStatusId")]
        public UserStatus UserStatus { get; set; }

        public int? AreaId { get; set; }

        [ForeignKey("AreaId")]
        public Area Area { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int QueuePosition { get; set; }
    }
}
