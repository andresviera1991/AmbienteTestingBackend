using MGP.Authentication.Persistance.Data.Tables.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGP.Authentication.Persistance.Data.Tables
{
    [Table("Parent")]
    public class Parent : EntityBaseGuid
    {
        [Required]
        [StringLength(8)]
        public string DocumentNumber { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [Required]
        [StringLength(256)]
        public string LastName { get; set; }

        public Guid PersonId { get; set; }

        [ForeignKey("PersonId")]
        public Person Person { get; set; }
    }
}
