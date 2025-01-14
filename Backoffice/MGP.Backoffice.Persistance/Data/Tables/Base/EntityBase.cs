using System.ComponentModel.DataAnnotations;

namespace MGP.Backoffice.Persistance.Data.Tables.Base
{
    public class EntityBase
    {
        [Required]
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
