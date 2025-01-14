using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MGP.Location.Persistance.Data.Tables
{
    [Table("Street")]
    public partial class Street
    {
        [Key]
        [Required]
        public long Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [Required]
        [StringLength(256)]
        public string FullName { get; set; }

        [Required]
        [StringLength(256)]
        public string Source { get; set; }
        [Required]
        [StringLength(256)]
        public string Category { get; set; }

        [Required]
        public int EndHeightRight { get; set; }

        [Required]
        public int EndHeightLeft { get; set; }

        [Required]
        public int StartHeightRight { get; set; }

        [Required]
        public int StartHeightLeft { get; set; }

        [ForeignKey("Locality")]
        public long? LocalityId { get; set; }

        public Locality Locality { get; set; }
    }
}
