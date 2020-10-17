namespace Chadwick.Database.Models
{
    public class AwardsShareManager
    {
        public int Id { get; set; }
        public string AwardName { get; set; }
        public int YearId { get; set; }
        public string LeagueId { get; set; }
        public string PlayerId { get; set; }
        public int? PointsWon { get; set; }
        public int? PointsMax { get; set; }
        public int? VotesFirst { get; set; }
    }
}