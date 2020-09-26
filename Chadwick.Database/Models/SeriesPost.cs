using CsvHelper.Configuration.Attributes;

namespace Chadwick.Database.Models
{
    public class SeriesPost
    {
        [Ignore]
        public int Id { get; set; }
        [Name("yearID")]
        public int YearId { get; set; }
        [Name("round")]
        public string LevelOfPlayoffs { get; set; }
        [Name("teamIDwinner")]
        public string WinningTeamId { get; set; }
        [Name("lgIDwinner")]
        public string WinningLeagueId { get; set; }
        [Name("teamIDloser")]
        public string LoserTeamId { get; set; }
        [Name("lgIDloser")]
        public string LoserLeagueId { get; set; }
        [Name("wins")]
        public int? Wins { get; set; }
        [Name("losses")]
        public int? Losses { get; set; }
        [Name("ties")]
        public int? Ties { get; set; }
    }
    
}