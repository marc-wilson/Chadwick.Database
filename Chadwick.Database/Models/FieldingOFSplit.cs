namespace Chadwick.Database.Models
{
    public class FieldingOFSplit
    {
        public int Id { get; set; }
        public string PlayerId {get;set;}
        public int YearId {get;set;}
        public int? Stint { get; set; }
        public string TeamId {get;set;}
        public string LeagueId {get;set;}
        public int? Games { get; set; }
        public int? GameStarts { get; set; }
    }
}