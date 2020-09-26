using CsvHelper.Configuration.Attributes;

namespace Chadwick.Database.Models
{
    public class TeamsHalf
    {
        [Ignore]
        public int Id { get; set; }
        [Name("yearID")]
        public int YearId {get;set;}
        [Name("lgID")]
        public string LeagueId {get;set;}
        [Name("teamID")]
        public string TeamId {get;set;}
        [Name("Half")]
        public int? Half { get; set; }
        [Name("divID")]
        public string DivisionId {get;set;}
        [Name("DivWin")]
        public string DivisionWin {get;set;}
        [Name("Rank")]
        public int? Rank {get;set;}
        [Name("G")]
        public int? Games { get; set; }
        [Name("W")]
        public int? Wins { get; set; }
        [Name("L")]
        public int? Losses { get; set; }
        
    }
}