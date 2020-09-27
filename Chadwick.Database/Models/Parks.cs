namespace Chadwick.Database.Models
{
    public class Parks
    {
        public int Id { get; set; }
        public string ParkKey { get; set; }
        public string ParkName { get; set; }
        public string ParkAlias { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}