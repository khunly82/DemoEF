using DemoEF.DAL.Configurations;
using DemoEF.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoEF.DAL
{
    public class DemoEFContext : DbContext
    {
        public DbSet<Player> Player { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Sponsor> Sponsor { get; set; }
        public DbSet<Training> Training { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=DemoEF.DB;integrated security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlayerConfig());
        }
    }
}
