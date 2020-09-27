using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chadwick.Database.Models
{
    public class People
    {
        public int Id { get; set; }
        public string PlayerId { get; set; }
        public int? BirthYear { get; set; }
        public int? BirthMonth { get; set; }
        public int? BirthDay { get; set; }
        public string BirthCountry { get; set; }
        public string BirthState { get; set; }
        public string BirthCity { get; set; }
        public int? DeathYear { get; set; }
        public int? DeathMonth { get; set; }
        public int? DeathDay { get; set; }
        public string DeathCountry { get; set; }
        public string DeathState { get; set; }
        public string DeathCity { get; set; }
        public string NameFirst { get; set; }
        public string NameLast { get; set; }
        public string NameGiven { get; set; }
        public int? Weight { get; set; }
        public int? Height { get; set; }
        public string Bats { get; set; }
        public string Throws { get; set; }
        public DateTime? Debut { get; set; } = null;
        public DateTime? FinalGame { get; set; } = null;
        public string RetrosheetId { get; set; }
        public string BaseballReferenceId { get; set; }
    }
}