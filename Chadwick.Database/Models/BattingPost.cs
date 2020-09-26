using CsvHelper.Configuration.Attributes;

namespace Chadwick.Database.Models
{
    public class BattingPost
    {
        [Ignore]
        public int Id { get; set; }
        [Name("yearID")]
        public int YearId { get; set; }
        [Name("round")]
        public string LevelOfPlayoffs { get; set; }
        [Name("playerID")]
        public string PlayerId { get; set; }
        [Name("teamID")]
        public string TeamId {get;set;}
        [Name("lgID")]
        public string LeagueId {get;set;}
        [Name("G")]
        public int? Games { get; set; }
        [Name("AB")]
        public int? AtBats { get; set; }
        [Name("R")]
        public int? Runs { get; set; }
        [Name("H")]
        public int? Hits { get; set; }
        [Name("2B")]
        public int? Doubles { get; set; }
        [Name("3B")]
        public int? Triples { get; set; }
        [Name("HR")]
        public int? HomeRuns { get; set; }
        [Name("RBI")]
        public int? RunsBattedIn { get; set; }
        [Name("SB")]
        public int? StolenBases { get; set; }
        [Name("CS")]
        public int? CaughtStealing { get; set; }
        [Name("BB")]
        public int? BaseOnBalls { get; set; }
        [Name("SO")]
        public int? Strikeouts { get; set; }
        [Name("IBB")]
        public int? IntentionalWalks { get; set; }
        [Name("HBP")]
        public int? HitByPitch { get; set; }
        [Name("SH")]
        public int? Sacrifices { get; set; }
        [Name("SF")]
        public int? SacrificeFlies { get; set; }
        [Name("GIDP")]
        public int? GroundedIntoDoublePlays { get; set; }
    }
}