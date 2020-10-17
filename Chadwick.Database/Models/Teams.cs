namespace Chadwick.Database.Models
{
    public class Teams
    {
        public int Id { get; set; }
        public string LeagueId {get;set;}
        public string TeamId {get;set;}
        public string FranchiseId {get;set;}
        public string DivisionId {get;set;}
        public int? Rank {get;set;}
        public int? Games { get; set; }
        public int? HomeGames { get; set; }
        public int? Wins { get; set; }
        public int? Losses { get; set; }
        public string DivisionWin {get;set;}
        public string WildCardWinner {get;set;}
        public string LeagueWin {get;set;}
        public string WorldSeriesWin {get;set;}
        public int? Runs { get; set; }
        public int? AtBats { get; set; }
        public int? Hits { get; set; }
        public int? Doubles { get; set; }
        public int? Triples { get; set; }
        public int? HomeRuns { get; set; }
        public int? Walks { get; set; }
        public int? Strikeouts { get; set; }
        public int? StolenBases { get; set; }
        public int? CaughtStealing { get; set; }
        public int? HitByPitch { get; set; }
        public int? SacrificeFlies { get; set; }
        public int? RunsAllowed { get; set; }
        public int? EarnedRunsAllowed { get; set; }
        public string EarnedRunsAverage { get; set; }
        public int? CompleteGames { get; set; }
        public int? Shutouts { get; set; }
        public int? Saves { get; set; }
        public int? OutsPitched { get; set; }
        public int? HitsAllowed { get; set; }
        public int? HomeRunsAllowed { get; set; }
        public int? WalksAllowed { get; set; }
        public int? StrikeoutsByPitchers { get; set; }
        public int? Errors { get; set; }
        public int? DoublePlays { get; set; }
        public decimal? FieldingPercentage { get; set; }
        public string Name { get; set; }
        public string Ballpark { get; set; }
        public int? Attendance { get; set; }
        public int? ThreeYearParkFactorForBatters { get; set; }
        public int? ThreeYearParkFactorForPitchers { get; set; }
        public string BaseballReferenceTeamId { get; set; }
        public string LahmanTeamId { get; set; }
        public string RetrosheetTeamId { get; set; }
    }
}