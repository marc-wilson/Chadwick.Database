namespace Chadwick.Database.Models
{
    public class FieldingPost
    {
        public int Id { get; set; }
        public string PlayerId { get; set; }
        public int YearId { get; set; }
        public string TeamId {get;set;}
        public string LeagueId {get;set;}
        public string LevelOfPlayoffs { get; set; }
        public string Position { get; set; }
        public int? Games { get; set; }
        public int? GameStarts { get; set; }
        public int? TimePlayedInFieldExpressedAsOuts { get; set; }
        public int? Putouts { get; set; }
        public int? Assists { get; set; }
        public int? Errors { get; set; }
        public int? DoublePlays { get; set; }
        public int? TriplePlays { get; set; }
        public int? PassedBalls { get; set; }
        public int? StolenBases { get; set; }
        public int? CaughtStealing { get; set; }
    }
}