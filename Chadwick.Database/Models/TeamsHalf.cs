namespace Chadwick.Database.Models
{
    public class TeamsHalf
    {
        public int Id { get; set; }
        public int YearId {get;set;}
        public string LeagueId {get;set;}
        public string TeamId {get;set;}
        public int? Half { get; set; }
        public string DivisionId {get;set;}
        public string DivisionWin {get;set;}
        public int? Rank {get;set;}
        public int? Games { get; set; }
        public int? Wins { get; set; }
        public int? Losses { get; set; }
    }
}