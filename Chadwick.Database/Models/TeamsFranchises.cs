using CsvHelper.Configuration.Attributes;

namespace Chadwick.Database.Models
{
    public class TeamsFranchises
    {
        [Ignore]
        public int Id { get; set; }
        [Name("franchID")]
        public string FranchiseId { get; set; }
        [Name("franchName")]
        public string Name { get; set; }
        [Name("active")]
        public string Active { get; set; }
        [Name("NAassoc")]
        public string NationalAssociationFranchiseId { get; set; }
    }
}