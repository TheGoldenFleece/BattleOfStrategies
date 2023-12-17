using BattleOfStrategies.Models;
using Microsoft.EntityFrameworkCore;

namespace BattleOfStrategies.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<MilitaryUnit> MilitaryUnits { get; set; }
    }
}
