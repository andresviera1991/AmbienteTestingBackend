using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MGP.Location.Persistance.Data.Tables
{
    [Table("Province")]
    public partial class Province
    {
        [Key]
        [Required]
        public int Id { get; set; }

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
        public double CentroidLon { get; set; }

        [Required]
        public double CentroidLat { get; set; }

        [Required]
        [StringLength(256)]
        public string IsoId { get; set; }

        [Required]
        [StringLength(256)]
        public string IsoName { get; set; }

        public ICollection<Department> Departments { get; set; }
    }
}