using System;
using System.ComponentModel.DataAnnotations;


namespace MGP.Notifications.Persistance.Data.Tables.Base
{
    public interface IEntityBaseGuid
    {
        

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

    }
}
