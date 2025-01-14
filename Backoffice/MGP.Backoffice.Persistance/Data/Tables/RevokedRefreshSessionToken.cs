using MGP.Backoffice.Persistance.Data.Tables.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGP.Backoffice.Persistance.Data.Tables
{
    [Table("RevokedRefreshSessionToken")]
    public class RevokedRefreshSessionToken : EntityBaseGuid
    {
        [Required]
        public string RefreshToken { get; set; }

        [Required]
        public Guid AgentId { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }
    }
}
