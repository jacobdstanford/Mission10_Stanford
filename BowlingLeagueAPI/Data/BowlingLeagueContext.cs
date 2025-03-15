using Microsoft.EntityFrameworkCore;
using BowlingLeagueAPI.Models; // Ensure you have your models defined

namespace BowlingLeagueAPI.Data
{
    public class BowlingLeagueContext : DbContext
    {
        public BowlingLeagueContext(DbContextOptions<BowlingLeagueContext> options)
            : base(options)
        {
        }

        // Add a DbSet for your bowlers.
        public DbSet<Bowler> Bowlers { get; set; }
    }
}
