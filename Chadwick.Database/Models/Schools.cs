using CsvHelper.Configuration.Attributes;

namespace Chadwick.Database.Models
{
    public class Schools
    {
        [Ignore]
        public int Id { get; set; }
        [Name("schoolID")]
        public string SchoolId { get; set; }
        [Name("name_full")]
        public string Name { get; set; }
        [Name("city")]
        public string City { get; set; }
        [Name("state")]
        public string State { get; set; }
        [Name("country")]
        public string Country { get; set; }
    }
}