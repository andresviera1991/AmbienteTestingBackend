using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MGP.Location.Persistance.Data.Tables
{
    [Table("Locality")]
    public partial class Locality
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
        public double Longitude { get; set; }

        [Required]
        public double Latitude { get; set; }

        [ForeignKey("Department")]
        public long? DepartmentId { get; set; }

        public Department Department { get; set; }

        public ICollection<Street> Streets { get; set; }
    }
}
