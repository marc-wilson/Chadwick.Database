namespace Chadwick.Database.Models
{
    public class Batting
    {
        public int Id { get; set; }
        public string PlayerId { get; set; }
        public int YearId { get; set; }
        public int? Stint { get; set; }
        public string TeamId { get;set; }
        public string LeagueId { get;set; }
        public int? Games { get; set; }
        public int? AtBats { get; set; }
        public int? Runs { get; set; }
        public int? Hits { get; set; }
        public int? Doubles { get; set; }
        public int? Triples { get; set; }
        public int? HomeRuns { get; set; }
        public int? RunsBattedIn { get; set; }
        public int? StolenBases { get; set; }
        public int? CaughtStealing { get; set; }
        public int? BaseOnBalls { get; set; }
        public int? Strikeouts { get; set; }
        public int? IntentionalWalks { get; set; }
        public int? HitByPitch { get; set; }
        public int? SacrificeHits { get; set; }
        public int? SacrificeFlies { get; set; }
        public int? GroundedIntoDoublePlays { get; set; }
    }
}