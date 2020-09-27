namespace Chadwick.Database.Models
{
    /// <summary>
    /// AllStarFull Table
    /// </summary>
    public class AllStarFull
    {
        public int Id { get; set; }
        public string PlayerId { get; set; }
        public int? YearId { get; set; }
        public int? GameNumber { get;set; }
        public string GameId { get; set; }
        public string TeamId { get;set; }
        public string LeagueId { get;set; }
        public int? GamesPlayed { get; set; }
        public int? StartingPosition { get; set; }
    }
}