using CsvHelper.Configuration.Attributes;

namespace Chadwick.Database.Models
{
    public class AwardsShareManager
    {
        [Ignore]
        public int Id { get; set; }
        [Name("awardID")]
        public string AwardName { get; set; }
        [Name("yearID")]
        public int YearId {get;set;}
        [Name("lgID")]
        public string LeagueId {get;set;}
        [Name("playerID")]
        public string PlayerId {get;set;}
        [Name("pointsWon")]
        public int? PointsWon { get; set; }
        [Name("pointsMax")]
        public int? PointsMax { get; set; }
        [Name("votesFirst")]
        public int? VotesFirst { get; set; }
    }
}