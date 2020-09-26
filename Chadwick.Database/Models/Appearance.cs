using CsvHelper.Configuration.Attributes;

namespace Chadwick.Database.Models
{
    public class Appearance
    {
        [Ignore]
        public int Id { get; set; }
        [Name("yearID")]
        public int YearId { get; set; }
        [Name("teamID")]
        public string TeamId { get; set; }
        [Name("lgID")]
        public string LeagueId { get; set; }
        [Name("playerID")]
        public string PlayerId { get; set; }
        [Name("G_all")]
        public int? TotalGamesPlayed { get; set; }
        [Name("GS")]
        public int? GamesStarted { get; set; }
        [Name("G_batting")]
        public int? GamesBatted { get; set; }
        [Name("G_defense")]
        public int? GamesDefense { get; set; }
        [Name("G_p")]
        public int? GamesAsPitcher { get; set; }
        [Name("G_c")]
        public int? GamesAsCatcher { get; set; }
        [Name("G_1b")]
        public int? GamesAsFirstBaseman { get; set; }
        [Name("G_2b")]
        public int? GamesAsSecondBaseman { get; set; }
        [Name("G_3b")]
        public int? GamesAsThirdBaseman { get; set; }
        [Name("G_ss")]
        public int? GamesAsShortStop { get; set; }
        [Name("G_lf")]
        public int? GamesAsLeftFielder { get; set; }
        [Name("G_cf")]
        public int? GamesAsCenterFielder { get; set; }
        [Name("G_rf")]
        public int? GamesAsRightFielder { get; set; }
        [Name("G_of")]
        public int? GamesAsOutfielder { get; set; }
        [Name("G_dh")]
        public int? GamesAsDesignatedHitter { get; set; }
        [Name("G_ph")]
        public int? GamesAsPinchHitter { get; set; }
        [Name("G_pr")]
        public int? GamesAsPinchRunner { get; set; }
    }
}