namespace BowlingLeagueAPI.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; } = null!;
        
        // Optional: If you want navigation back to Bowlers
        // public ICollection<Bowler>? Bowlers { get; set; }
    }
}
