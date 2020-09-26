using CsvHelper.Configuration.Attributes;

namespace Chadwick.Database.Models
{
    public class CollegePlaying
    {
        [Ignore]
        public int Id { get; set; }
        [Name("playerID")]
        public string PlayerId { get; set; }
        [Name("schoolID")]
        public string SchoolId { get; set; }
        [Name("yearID")]
        public int YearId { get; set; }
    }
}