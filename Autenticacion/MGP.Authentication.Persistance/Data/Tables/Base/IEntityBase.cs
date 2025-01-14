using System;
using System.ComponentModel.DataAnnotations;


namespace MGP.Authentication.Persistance.Data.Tables.Base
{
    public interface IEntityBase
    {

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
