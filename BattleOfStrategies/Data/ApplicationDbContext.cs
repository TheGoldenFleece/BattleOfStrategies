using BattleOfStrategies.Data.EntityConfiguration;
using BattleOfStrategies.Models;
using Microsoft.EntityFrameworkCore;

namespace BattleOfStrategies.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new MilitaryUnitConfiguration());
        }

        public DbSet<MilitaryUnit> MilitaryUnits { get; set; }
    }
}
