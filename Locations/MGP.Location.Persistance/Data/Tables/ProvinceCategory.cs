using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MGP.Location.Persistance.Data.Tables
{
    [Table("ProvinceCategory")]
    public partial class ProvinceCategory
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Description { get; set; }
    }
}
