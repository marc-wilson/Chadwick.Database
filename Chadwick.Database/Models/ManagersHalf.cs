using CsvHelper.Configuration.Attributes;

namespace Chadwick.Database.Models
{
    public class ManagersHalf
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
        [Name("half")]
        public int? Half { get; set; }
        [Name("G")]
        public int? Games { get; set; }
        [Name("W")]
        public int? Wins { get; set; }
        [Name("L")]
        public int? Losses { get; set; }
        [Name("rank")]
        public int? Rank { get; set; }
    }
}