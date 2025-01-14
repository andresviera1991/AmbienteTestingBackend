using MGP.Authentication.Persistance.Data.Tables.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGP.Authentication.Persistance.Data.Tables
{
    [Table("Person")]
    public class Person : EntityBaseGuid
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

        [Required]
        public int GenderId { get; set; }

        [ForeignKey("GenderId")]
        public Gender Gender { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public bool Resident { get; set; }

        public Guid? AddressId { get; set; }

        [ForeignKey("AddressId")]
        public Address Address { get; set; }

        public Guid? PhoneNumberId { get; set; }

        [ForeignKey("PhoneNumberId")]
        public PhoneNumber PhoneNumber { get; set; }

    }
}
