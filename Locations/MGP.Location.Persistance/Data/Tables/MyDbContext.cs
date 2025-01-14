using Microsoft.EntityFrameworkCore;
using MGP.Location.Persistance.Data.Seeds;

namespace MGP.Location.Persistance.Data.Tables
{
    public class MyDbContext : DbContext
    {
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Locality> Localities { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Street> Streets { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Province Configuration
            modelBuilder.Entity<Province>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Province>()
                .Property(p => p.Id)
                .ValueGeneratedNever()
                .IsRequired();

            modelBuilder.Entity<Province>()
                .Property(p => p.Name)
                .HasMaxLength(256)
                .IsRequired();

            modelBuilder.Entity<Province>()
                .Property(p => p.FullName)
                .HasMaxLength(256)
                .IsRequired();

            modelBuilder.Entity<Province>()
                .Property(p => p.Source)
                .HasMaxLength(256)
                .IsRequired();

            modelBuilder.Entity<Province>()
                .Property(p => p.Category)
                .HasMaxLength(256)
                .IsRequired();

            modelBuilder.Entity<Province>()
                .Property(p => p.CentroidLon)
                .IsRequired();

            modelBuilder.Entity<Province>()
                .Property(p => p.CentroidLat)
                .IsRequired();

            modelBuilder.Entity<Province>()
                .Property(p => p.IsoId)
                .HasMaxLength(256)
                .IsRequired();

            modelBuilder.Entity<Province>()
                .Property(p => p.IsoName)
                .HasMaxLength(256)
                .IsRequired();
            #endregion

            #region Locality Configuration
            modelBuilder.Entity<Locality>()
                .HasKey(l => l.Id);

            modelBuilder.Entity<Locality>()
                .Property(l => l.Id)
                .ValueGeneratedNever()
                .IsRequired();

            modelBuilder.Entity<Locality>()
                .Property(l => l.Name)
                .HasMaxLength(256)
                .IsRequired();

            modelBuilder.Entity<Locality>()
                .Property(l => l.FullName)
                .HasMaxLength(256)
                .IsRequired();

            modelBuilder.Entity<Locality>()
                .Property(l => l.Source)
                .HasMaxLength(256)
                .IsRequired();

            modelBuilder.Entity<Locality>()
                .Property(l => l.Category)
                .HasMaxLength(256)
                .IsRequired();

            modelBuilder.Entity<Locality>()
                .Property(l => l.Longitude)
                .IsRequired();

            modelBuilder.Entity<Locality>()
                .Property(l => l.Latitude)
                .IsRequired();

            modelBuilder.Entity<Locality>()
                .HasOne(l => l.Department)
                .WithMany(p => p.Localities)
                .HasForeignKey(l => l.DepartmentId)
                .OnDelete(DeleteBehavior.SetNull);
            #endregion

            #region Municipality Configuration
            modelBuilder.Entity<Department>()
                .HasKey(m => m.Id);

            modelBuilder.Entity<Department>()
                .Property(m => m.Id)
                .ValueGeneratedNever()
                .IsRequired();

            modelBuilder.Entity<Department>()
                .Property(m => m.Name)
                .HasMaxLength(256)
                .IsRequired();

            modelBuilder.Entity<Department>()
                .Property(m => m.Source)
                .HasMaxLength(256)
                .IsRequired();

            modelBuilder.Entity<Department>()
                .Property(m => m.Category)
                .HasMaxLength(256)
                .IsRequired();

            modelBuilder.Entity<Department>()
                .Property(m => m.Longitude)
                .IsRequired();

            modelBuilder.Entity<Department>()
                .Property(m => m.Latitude)
                .IsRequired();

            modelBuilder.Entity<Department>()
                .HasOne(l => l.Province)
                .WithMany(m => m.Departments)
                .HasForeignKey(l => l.ProvinceId)
                .OnDelete(DeleteBehavior.SetNull);
            #endregion

            #region Street Configuration
            modelBuilder.Entity<Street>()
                .HasKey(l => l.Id);

            modelBuilder.Entity<Street>()
                .Property(l => l.Id)
                .ValueGeneratedNever()
                .IsRequired();

            modelBuilder.Entity<Street>()
                .Property(l => l.Name)
                .HasMaxLength(256)
                .IsRequired();

            modelBuilder.Entity<Street>()
                .Property(l => l.FullName)
                .HasMaxLength(256)
                .IsRequired();

            modelBuilder.Entity<Street>()
                .Property(l => l.Source)
                .HasMaxLength(256)
                .IsRequired();

            modelBuilder.Entity<Street>()
                .Property(l => l.Category)
                .HasMaxLength(256)
                .IsRequired();
            
            modelBuilder.Entity<Street>()
                .Property(l => l.EndHeightRight)
                .IsRequired();

            modelBuilder.Entity<Street>()
                .Property(l => l.EndHeightLeft)
                .IsRequired();

            modelBuilder.Entity<Street>()
                .Property(l => l.StartHeightRight)
                .IsRequired();

            modelBuilder.Entity<Street>()
                .Property(l => l.StartHeightLeft)
                .IsRequired();

            modelBuilder.Entity<Street>()
                .HasOne(l => l.Locality)
                .WithMany(p => p.Streets)
                .HasForeignKey(l => l.LocalityId)
                .OnDelete(DeleteBehavior.SetNull);
            #endregion

            #region Seeds
            modelBuilder.ApplyConfiguration(new ProvincesSeed());
            modelBuilder.ApplyConfiguration(new DepartmentsSeed());
            modelBuilder.ApplyConfiguration(new LocalitiesSeed());
            modelBuilder.ApplyConfiguration(new StreetsSeed());
            modelBuilder.ApplyConfiguration(new StreetsBatanSeed());
            modelBuilder.ApplyConfiguration(new StreetsBarrioSantaPaulaSeed());
            modelBuilder.ApplyConfiguration(new StreetsChapadmalalSeed());
            modelBuilder.ApplyConfiguration(new StreetsEstacionChapadmalalSeed());
            modelBuilder.ApplyConfiguration(new StreetsSierraDeLosPadresSeed());
            #endregion
        }
    }
}