using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chadwick.Database.Models
{
    public class ChadwickTables
    {
        [Key]
        public int TableId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Alias { get; set; }
        public List<ChadwickFields> Fields { get; set; }
    }
}