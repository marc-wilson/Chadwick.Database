using CsvHelper.Configuration.Attributes;

namespace Chadwick.Database.Models
{
    public class Teams
    {
        [Ignore]
        public int Id { get; set; }
        [Name("lgID")]
        public string LeagueId {get;set;}
        [Name("teamID")]
        public string TeamId {get;set;}
        [Name("franchID")]
        public string FranchiseId {get;set;}
        [Name("divID")]
        public string DivisionId {get;set;}
        [Name("Rank")]
        public int? Rank {get;set;}
        [Name("G")]
        public int? Games { get; set; }
        [Name("Ghome")]
        public int? HomeGames { get; set; }
        [Name("W")]
        public int? Wins { get; set; }
        [Name("L")]
        public int? Losses { get; set; }
        [Name("DivWin")]
        public string DivisionWin {get;set;}
        [Name("WCWin")]
        public string WildCardWinner {get;set;}
        [Name("LgWin")]
        public string LeagueWin {get;set;}
        [Name("WSWin")]
        public string WorldSeriesWin {get;set;}
        [Name("R")]
        public int? Runs { get; set; }
        [Name("AB")]
        public int? AtBats { get; set; }
        [Name("H")]
        public int? Hits { get; set; }
        [Name("2B")]
        public int? Doubles { get; set; }
        [Name("3B")]
        public int? Triples { get; set; }
        [Name("HR")]
        public int? HomeRuns { get; set; }
        [Name("BB")]
        public int? Walks { get; set; }
        [Name("SO")]
        public int? Strikeouts { get; set; }
        [Name("SB")]
        public int? StolenBases { get; set; }
        [Name("CS")]
        public int? CaughtStealing { get; set; }
        [Name("HBP")]
        public int? HitByPitch { get; set; }
        [Name("SF")]
        public int? SacrificeFlies { get; set; }
        [Name("RA")]
        public int? RunsAllowed { get; set; }
        [Name("ER")]
        public int? EarnedRunsAllowed { get; set; }
        [Name("ERA")]
        public string EarnedRunsAverage { get; set; }
        [Name("CG")]
        public int? CompleteGames { get; set; }
        [Name("SHO")]
        public int? Shutouts { get; set; }
        [Name("SV")]
        public int? Saves { get; set; }
        [Name("IPouts")]
        public int? OutsPitched { get; set; }
        [Name("HA")]
        public int? HitsAllowed { get; set; }
        [Name("HRA")]
        public int? HomeRunsAllowed { get; set; }
        [Name("BBA")]
        public int? WalksAllowed { get; set; }
        [Name("SOA")]
        public int? StrikeoutsByPitchers { get; set; }
        [Name("E")]
        public int? Errors { get; set; }
        [Name("DP")]
        public int? DoublePlays { get; set; }
        [Name("FP")]
        public decimal? FieldingPercentage { get; set; }
        [Name("name")]
        public string Name { get; set; }
        [Name("park")]
        public string Ballpark { get; set; }
        [Name("attendance")]
        public int? Attendance { get; set; }
        [Name("BPF")]
        public int? ThreeYearParkFactorForBatters { get; set; }
        [Name("PPF")]
        public int? ThreeYearParkFactorForPitchers { get; set; }
        [Name("teamIDBR")]
        public string BaseballReferenceTeamId { get; set; }
        [Name("teamIDlahman45")]
        public string LahmanTeamId { get; set; }
        [Name("teamIDretro")]
        public string RetrosheetTeamId { get; set; }
    }
}