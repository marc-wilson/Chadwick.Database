using CsvHelper.Configuration.Attributes;

namespace Chadwick.Database.Models
{
    public class Salaries
    {
        [Ignore]
        public int Id { get; set; }
        [Name("yearID")]
        public int YearId { get; set; }
        [Name("teamID")]
        public string TeamId {get;set;}
        [Name("lgID")]
        public string LeagueId {get;set;}
        [Name("playerID")]
        public string PlayerId { get; set; }
        [Name("salary")]
        public int? Salary { get; set; }
        
    }
}