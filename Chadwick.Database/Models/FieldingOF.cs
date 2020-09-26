using CsvHelper.Configuration.Attributes;

namespace Chadwick.Database.Models
{
    public class FieldingOF
    {
        [Ignore]
        public int Id { get; set; }
        [Name("playerID")]
        public string PlayerId {get;set;}
        [Name("yearID")]
        public int YearId {get;set;}
        [Name("stint")]
        public int? Stint { get; set; }
        [Name("Glf")]
        public int? GamesPlayedInLeftField { get; set; }
        [Name("Gcf")]
        public int? GamesPlayedInCenterField { get; set; }
        [Name("Grf")]
        public int? GamesPlayedInRightField { get; set; }
    }
}