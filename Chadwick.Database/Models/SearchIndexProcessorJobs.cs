using System;
using System.ComponentModel.DataAnnotations;

namespace Chadwick.Database.Models
{
    public class SearchIndexProcessorJobs
    {
        [Key]
        public int IndexId { get; set; }
        public string IndexName { get; set; }
        public DateTime Started { get; set; }
        public DateTime Finished { get; set; }
        public long DocumentsProcessed { get; set; }
        public string Status { get; set; }
        public long StorageSize { get; set; }

        public SearchIndexProcessorJobs()
        {
            Started = DateTime.UtcNow;
        }
    }
}