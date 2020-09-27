namespace Chadwick.Database.Models
{
    public class SeriesPost
    {
        public int Id { get; set; }
        public int YearId { get; set; }
        public string LevelOfPlayoffs { get; set; }
        public string WinningTeamId { get; set; }
        public string WinningLeagueId { get; set; }
        public string LoserTeamId { get; set; }
        public string LoserLeagueId { get; set; }
        public int? Wins { get; set; }
        public int? Losses { get; set; }
        public int? Ties { get; set; }
    }
    
}