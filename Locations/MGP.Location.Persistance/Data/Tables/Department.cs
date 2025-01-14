using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MGP.Location.Persistance.Data.Tables
{
    [Table("Department")]
    public partial class Department
    {
        [Key]
        [Required]
        public long Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [Required]
        [StringLength(256)]
        public string Source { get; set; }

        [Required]
        [StringLength(256)]
        public string Category { get; set; }

        [Required]
        public double Longitude { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        [ForeignKey("Province")]
        public int ProvinceId { get; set; }

        public Province Province { get; set; }

        public ICollection<Locality> Localities { get; set; }
    }
}
