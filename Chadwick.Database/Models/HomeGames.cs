using System;

namespace Chadwick.Database.Models
{
    public class HomeGames
    {
        public int Id { get; set; }
        public int YearKey { get; set; }
        public string LeagueKey { get; set; }
        public string TeamKey { get; set; }
        public string ParkKey { get; set; }
        public DateTime SpanFirst { get; set; }
        public DateTime SpanLast { get; set; }
        public int? Games { get; set; }
        public int? Openings { get; set; }
        public int? Attendance { get; set; }
    }
}