using CsvHelper.Configuration.Attributes;

namespace Chadwick.Database.Models
{
    public class AwardsManager
    {
        [Ignore]
        public int Id { get; set; }
        [Name("playerID")]
        public string PlayerId {get;set;}
        [Name("awardID")]
        public string AwardName { get; set; }
        [Name("yearID")]
        public int YearId {get;set;}
        [Name("lgID")]
        public string LeagueId {get;set;}
        [Name("tie")]
        public string Tie { get; set; }
        [Name("notes")]
        public string Notes { get; set; }
    }
}