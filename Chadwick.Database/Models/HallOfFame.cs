using CsvHelper.Configuration.Attributes;

namespace Chadwick.Database.Models
{
    public class HallOfFame
    {
        [Ignore]
        public int Id { get; set; }
        [Name("playerID")]
        public string PlayerId {get;set;}
        [Name("yearID")]
        public int YearId {get;set;}
        [Name("votedBy")]
        public string VotedByMethod { get; set; }
        [Name("ballots")]
        public int? TotalBallotsCast { get; set; }
        [Name("needed")]
        public int? VotesNeeded { get; set; }
        [Name("votes")]
        public int? TotalVotesReceived { get; set; }
        [Name("inducted")]
        public string Inducted { get; set; }
        [Name("category")]
        public string Category { get; set; }
        [Name("needed_note")]
        public string NeededNote { get; set; }
    }
}