namespace Chadwick.Database.Models
{
    public class Managers
    {
        public int Id { get; set; }
        public string PlayerId {get;set;}
        public int YearId {get;set;}
        public string TeamId {get;set;}
        public string LeagueId {get;set;}
        public int? ManagerialOrder { get; set; }
        public int? Games { get; set; }
        public int? Wins { get; set; }
        public int? Losses { get; set; }
        public int? Rank { get; set; }
        public string PlayerManager { get; set; }
    }
}