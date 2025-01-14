using MGP.Authentication.Persistance.Data.Tables.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGP.Authentication.Persistance.Data.Tables
{
    [Table("User")]
    public partial class User : EntityBaseGuid
    {

        [Required]
        [StringLength(256)]
        public string UserName { get; set; }

        [Required]
        [StringLength(256)]
        public string Password { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public Guid PersonId { get; set; }

        [ForeignKey("PersonId")]
        public Person Person { get; set; }

        [Required]
        public int UserStatusId { get; set; }

        [ForeignKey("UserStatusId")]
        public UserStatus UserStatus { get; set; }

        public int LevelId { get; set; }

        [ForeignKey("LevelId")]
        public UserLevel Level { get; set; }

        public int FailedLoginAttempts { get; set; }

    }
}
