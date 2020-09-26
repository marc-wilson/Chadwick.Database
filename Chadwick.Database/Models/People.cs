using System;
using System.ComponentModel.DataAnnotations.Schema;
using CsvHelper.Configuration.Attributes;

namespace Chadwick.Database.Models
{
    public class People
    {
        [Ignore] public int Id { get; set; }
        [Name("playerID")] public string PlayerId { get; set; }
        [Name("birthYear")] public int? BirthYear { get; set; }
        [Name("birthMonth")] public int? BirthMonth { get; set; }
        [Name("birthDay")] public int? BirthDay { get; set; }
        [Name("birthCountry")] public string BirthCountry { get; set; }
        [Name("birthState")] public string BirthState { get; set; }
        [Name("birthCity")] public string BirthCity { get; set; }
        [Name("deathYear")] public int? DeathYear { get; set; }
        [Name("deathMonth")] public int? DeathMonth { get; set; }
        [Name("deathDay")] public int? DeathDay { get; set; }
        [Name("deathCountry")] public string DeathCountry { get; set; }
        [Name("deathState")] public string DeathState { get; set; }
        [Name("deathCity")] public string DeathCity { get; set; }
        [Name("nameFirst")] public string NameFirst { get; set; }
        [Name("nameLast")] public string NameLast { get; set; }
        [NotMapped] public string FullName => $"{NameFirst} {NameLast}";
        [Name("nameGiven")] public string NameGiven { get; set; }
        [Name("weight")] public int? Weight { get; set; }
        [Name("height")] public int? Height { get; set; }
        [Name("bats")] public string Bats { get; set; }
        [Name("throws")] public string Throws { get; set; }
        [Name("debut")] public DateTime? Debut { get; set; } = null;
        [Name("finalGame")] public DateTime? FinalGame { get; set; } = null;
        [Name("retroID")] public string RetrosheetId { get; set; }
        [Name("bbrefID")] public string BaseballReferenceId { get; set; }
    }
}