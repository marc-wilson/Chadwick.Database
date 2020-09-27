namespace Chadwick.Database.Models
{
    public class Appearance
    {
        public int Id { get; set; }
        public int YearId { get; set; }
        public string TeamId { get; set; }
        public string LeagueId { get; set; }
        public string PlayerId { get; set; }
        public int? TotalGamesPlayed { get; set; }
        public int? GamesStarted { get; set; }
        public int? GamesBatted { get; set; }
        public int? GamesDefense { get; set; }
        public int? GamesAsPitcher { get; set; }
        public int? GamesAsCatcher { get; set; }
        public int? GamesAsFirstBaseman { get; set; }
        public int? GamesAsSecondBaseman { get; set; }
        public int? GamesAsThirdBaseman { get; set; }
        public int? GamesAsShortStop { get; set; }
        public int? GamesAsLeftFielder { get; set; }
        public int? GamesAsCenterFielder { get; set; }
        public int? GamesAsRightFielder { get; set; }
        public int? GamesAsOutfielder { get; set; }
        public int? GamesAsDesignatedHitter { get; set; }
        public int? GamesAsPinchHitter { get; set; }
        public int? GamesAsPinchRunner { get; set; }
    }
}