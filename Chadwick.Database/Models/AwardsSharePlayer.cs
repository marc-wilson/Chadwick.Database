namespace Chadwick.Database.Models
{
    public class AwardsSharePlayer
    {
        public int Id { get; set; }
        public string AwardName { get; set; }
        public int YearId { get; set; }
        public string LeagueId { get; set; }
        public string PlayerId { get; set; }
        public decimal? PointsWon { get; set; }
        public int? PointsMax { get; set; }
        public decimal? VotesFirst { get; set; }
    }
}