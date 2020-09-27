namespace Chadwick.Database.Models
{
    public class Salaries
    {
        public int Id { get; set; }
        public int YearId { get; set; }
        public string TeamId {get;set;}
        public string LeagueId {get;set;}
        public string PlayerId { get; set; }
        public int? Salary { get; set; }
        
    }
}