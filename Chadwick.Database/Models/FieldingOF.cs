namespace Chadwick.Database.Models
{
    public class FieldingOF
    {
        public int Id { get; set; }
        public string PlayerId {get;set;}
        public int YearId {get;set;}
        public int? Stint { get; set; }
        public int? GamesPlayedInLeftField { get; set; }
        public int? GamesPlayedInCenterField { get; set; }
        public int? GamesPlayedInRightField { get; set; }
    }
}