using System;
using CsvHelper.Configuration.Attributes;

namespace Chadwick.Database.Models
{
    public class HomeGames
    {
        [Ignore]
        public int Id { get; set; }
        [Name("year.key")]
        public int YearKey { get; set; }
        [Name("league.key")]
        public string LeagueKey { get; set; }
        [Name("team.key")]
        public string TeamKey { get; set; }
        [Name("park.key")]
        public string ParkKey { get; set; }
        [Name("span.first")]
        public DateTime SpanFirst { get; set; }
        [Name("span.last")]
        public DateTime SpanLast { get; set; }
        [Name("games")]
        public int? Games { get; set; }
        [Name("openings")]
        public int? Openings { get; set; }
        [Name("attendance")]
        public int? Attendance { get; set; }
    }
}