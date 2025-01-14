using MGP.Authentication.Persistance.Data.Tables.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGP.Authentication.Persistance.Data.Tables
{
    [Table("Address")]
    public class Address : EntityBaseGuid
    {

        [Required]
        public string Street { get; set; }

        [Required]
        public string StreetNumber { get; set; }

        public string Floor { get; set; }

        public string Apartment { get; set; }

        public string BetweenStreetOne { get; set; }

        public string BetweenStreetTwo { get; set; }

        [Required]
        public int LocalityId { get; set; }


    }
}
