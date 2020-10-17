namespace Chadwick.Database.Models
{
    public class HallOfFame
    {
        public int Id { get; set; }
        public string PlayerId {get;set;}
        public int YearId {get;set;}
        public string VotedByMethod { get; set; }
        public int? TotalBallotsCast { get; set; }
        public int? VotesNeeded { get; set; }
        public int? TotalVotesReceived { get; set; }
        public string Inducted { get; set; }
        public string Category { get; set; }
        public string NeededNote { get; set; }
    }
}