using CsvHelper.Configuration.Attributes;

namespace Chadwick.Database.Models
{
    public class FieldingOFSplit
    {
        [Ignore]
        public int Id { get; set; }
        [Name("playerID")]
        public string PlayerId {get;set;}
        [Name("yearID")]
        public int YearId {get;set;}
        [Name("stint")]
        public int? Stint { get; set; }
        [Name("teamID")]
        public string TeamId {get;set;}
        [Name("lgID")]
        public string LeagueId {get;set;}
        [Name("G")]
        public int? Games { get; set; }
        [Name("GS")]
        public int? GameStarts { get; set; }
    }
}