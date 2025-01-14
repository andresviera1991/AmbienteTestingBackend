using MGP.Authentication.Persistance.Data.Tables.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGP.Authentication.Persistance.Data.Tables
{
    [Table("RevokedRefreshToken")]
    public class RevokedRefreshToken : EntityBaseGuid
    {
        
        [Required]
        public string RefreshToken { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }
    }
}
