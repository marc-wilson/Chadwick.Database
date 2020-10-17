namespace Chadwick.Database.Models
{
    public class PitchingPost
    {
        public int Id { get; set; }
        public string PlayerId { get; set; }
        public int YearId { get; set; }
        public string LevelOfPlayoffs { get; set; }
        public string TeamId {get;set;}
        public string LeagueId {get;set;}
        public int? Wins { get; set; }
        public int? Losses { get; set; }
        public int? Games { get; set; }
        public int? GameStarts { get; set; }
        public int? CompleteGames { get; set; }
        public int? Shutouts { get; set; }
        public int? Saves { get; set; }
        public int? OutsPitched { get; set; }
        public int? Hits { get; set; }
        public int? EarnedRuns { get; set; }
        public int? HomeRuns { get; set; }
        public int? Walks { get; set; }
        public int? Strikeouts { get; set; }
        public decimal? OpponentBattingAverage { get; set; }
        public string EarnedRunsAverage { get; set; }
        public int? IntentionalWalks { get; set; }
        public int? WildPitches { get; set; }
        public int? BattersHitByPitch { get; set; }
        public int? Balks { get; set; }
        public int? BattersFaced { get; set; }
        public int? GamesFinished { get; set; }
        public int? RunsAllowed { get; set; }
        public int? SacrificeHitsAllowed { get; set; }
        public int? SacrificeFliesAllowed { get; set; }
        public int? GroundedIntoDoublePlays { get; set; }
        
    }
}