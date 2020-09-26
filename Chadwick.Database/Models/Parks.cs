using CsvHelper.Configuration.Attributes;

namespace Chadwick.Database.Models
{
    public class Parks
    {
        [Ignore]
        public int Id { get; set; }
        [Name("park.key")]
        public string ParkKey { get; set; }
        [Name("park.name")]
        public string ParkName { get; set; }
        [Name("park.alias")]
        public string ParkAlias { get; set; }
        [Name("city")]
        public string City { get; set; }
        [Name("state")]
        public string State { get; set; }
        [Name("country")]
        public string Country { get; set; }
    }
}