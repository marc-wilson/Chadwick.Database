using CsvHelper.Configuration.Attributes;

namespace Chadwick.Database.Models
{
    public class PitchingPost
    {
        [Ignore]
        public int Id { get; set; }
        [Name("playerID")]
        public string PlayerId { get; set; }
        [Name("yearID")]
        public int YearId { get; set; }
        [Name("round")]
        public string LevelOfPlayoffs { get; set; }
        [Name("teamID")]
        public string TeamId {get;set;}
        [Name("lgID")]
        public string LeagueId {get;set;}
        [Name("W")]
        public int? Wins { get; set; }
        [Name("L")]
        public int? Losses { get; set; }
        [Name("G")]
        public int? Games { get; set; }
        [Name("GS")]
        public int? GameStarts { get; set; }
        [Name("CG")]
        public int? CompleteGames { get; set; }
        [Name("SHO")]
        public int? Shutouts { get; set; }
        [Name("SV")]
        public int? Saves { get; set; }
        [Name("IPouts")]
        public int? OutsPitched { get; set; }
        [Name("H")]
        public int? Hits { get; set; }
        [Name("ER")]
        public int? EarnedRuns { get; set; }
        [Name("HR")]
        public int? HomeRuns { get; set; }
        [Name("BB")]
        public int? Walks { get; set; }
        [Name("SO")]
        public int? Strikeouts { get; set; }
        [Name("BAOpp")]
        public decimal? OpponentBattingAverage { get; set; }
        [Name("ERA")]
        public string EarnedRunsAverage { get; set; }
        [Name("IBB")]
        public int? IntentionalWalks { get; set; }
        [Name("WP")]
        public int? WildPitches { get; set; }
        [Name("HBP")]
        public int? BattersHitByPitch { get; set; }
        [Name("BK")]
        public int? Balks { get; set; }
        [Name("BFP")]
        public int? BattersFaced { get; set; }
        [Name("GF")]
        public int? GamesFinished { get; set; }
        [Name("R")]
        public int? RunsAllowed { get; set; }
        [Name("SH")]
        public int? SacrificeHitsAllowed { get; set; }
        [Name("SF")]
        public int? SacrificeFliesAllowed { get; set; }
        [Name("GIDP")]
        public int? GroundedIntoDoublePlays { get; set; }
        
    }
}