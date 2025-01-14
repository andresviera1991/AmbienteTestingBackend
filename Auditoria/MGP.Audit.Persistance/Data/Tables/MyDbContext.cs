using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MGP.Audit.Persistance.Data.Tables
{
    public partial class MyDbContext : DbContext
    {
        public DbSet<Audit> Audits { get; set; }

        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}