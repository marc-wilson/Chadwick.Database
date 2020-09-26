using CsvHelper.Configuration.Attributes;

namespace Chadwick.Database.Models
{
    public class Managers
    {
        [Ignore]
        public int Id { get; set; }
        [Name("playerID")]
        public string PlayerId {get;set;}
        [Name("yearID")]
        public int YearId {get;set;}
        [Name("teamID")]
        public string TeamId {get;set;}
        [Name("lgID")]
        public string LeagueId {get;set;}
        [Name("inseason")]
        public int? ManagerialOrder { get; set; }
        [Name("G")]
        public int? Games { get; set; }
        [Name("W")]
        public int? Wins { get; set; }
        [Name("L")]
        public int? Losses { get; set; }
        [Name("rank")]
        public int? Rank { get; set; }
        [Name("plyrMgr")]
        public string PlayerManager { get; set; }
    }
}