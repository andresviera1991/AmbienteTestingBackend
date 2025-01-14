﻿using System.ComponentModel.DataAnnotations;

namespace MGP.Backoffice.Persistance.Data.Tables.Base
{
    public class EntityBaseGuid
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

    }
}
