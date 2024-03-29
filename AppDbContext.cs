using Microsoft.EntityFrameworkCore;
using TurboAZ2.Entities;

namespace Turbo.az.Entity
{
    public class AppDbContext : DbContext
    {

        public AppDbContext()
            : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Database=Turboaz;User Id=YAQUB/ahmed;Password=;Encrypt=false;App=Orm",
                opt =>
                {
                    opt.MigrationsHistoryTable("MigrationHistory");
                });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }

        public DbSet<Brendler> Brendlers { get; set; }

        public DbSet<Modeller> Modeller { get; set; }
        public DbSet<Elan> Elanlar { get; set; }







    }
}