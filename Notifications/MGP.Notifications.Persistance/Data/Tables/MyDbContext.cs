using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MGP.Notifications.Persistance.Data.Tables
{
    public partial class MyDbContext : DbContext
    {
        public DbSet<Notification> Notificationss { get; set; }

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