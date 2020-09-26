using CsvHelper.Configuration.Attributes;

namespace Chadwick.Database.Models
{
    public class Fielding
    {
        [Ignore]
        public int Id { get; set; }
        [Name("playerID")]
        public string PlayerId { get; set; }
        [Name("yearID")]
        public int YearId { get; set; }
        [Name("stint")]
        public int? Stint { get; set; }
        [Name("teamID")]
        public string TeamId {get;set;}
        [Name("lgID")]
        public string LeagueId {get;set;}
        [Name("POS")]
        public string Position { get; set; }
        [Name("G")]
        public int? Games { get; set; }
        [Name("GS")]
        public int? GameStarts { get; set; }
        [Name("InnOuts")]
        public int? TimePlayedInFieldExpressedAsOuts { get; set; }
        [Name("PO")]
        public int? Putouts { get; set; }
        [Name("A")]
        public int? Assists { get; set; }
        [Name("E")]
        public int? Errors { get; set; }
        [Name("DP")]
        public int? DoublePlays { get; set; }
        [Name("PB")]
        public int? PassedBalls { get; set; }
        [Name("WP")]
        public int? WildPitches { get; set; }
        [Name("SB")]
        public int? StolenBases { get; set; }
        [Name("CS")]
        public int? CaughtStealing { get; set; }
        [Name("ZR")]
        public int? ZoneRating { get; set; }
    }
}