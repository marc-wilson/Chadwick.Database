using CsvHelper.Configuration.Attributes;

namespace Chadwick.Database.Models
{
    /// <summary>
    /// AllStarFull Table
    /// </summary>
    public class AllStarFull
    {
        [Ignore]
        public int Id { get; set; }
        [Name("playerID")]
        public string PlayerId { get; set; }
        [Name("yearID")]
        public int? YearId { get; set; }
        [Name("gameNum")]
        public int? GameNumber { get;set; }
        [Name("gameID")]
        public string GameId { get; set; }
        [Name("teamID")]
        public string TeamId { get;set; }
        [Name("lgID")]
        public string LeagueId { get;set; }
        [Name("GP")]
        public int? GamesPlayed { get; set; }
        [Name("startingPos")]
        public int? StartingPosition { get; set; }
    }
}