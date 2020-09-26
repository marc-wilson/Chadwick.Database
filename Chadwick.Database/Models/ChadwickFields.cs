using System.ComponentModel.DataAnnotations;

namespace Chadwick.Database.Models
{
    public class ChadwickFields
    {
        [Key]
        public int FieldId { get; set; }
        public string CamelCaseName { get; set; }
        public string Name { get; set; }
        public string FriendlyName { get; set; }
        public string ChadwickName { get; set; }
        public string AbbreviatedName { get; set; }
        public string Description { get; set; }
        public int TableId { get; set; }
        public ChadwickTables Table { get; set; }
    }
}