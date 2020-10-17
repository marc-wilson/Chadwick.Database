namespace Chadwick.Database.Models
{
    public class TeamsFranchises
    {
        public int Id { get; set; }
        public string FranchiseId { get; set; }
        public string Name { get; set; }
        public string Active { get; set; }
        public string NationalAssociationFranchiseId { get; set; }
    }
}