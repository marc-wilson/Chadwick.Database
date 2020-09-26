using System;
using System.ComponentModel.DataAnnotations;

namespace Chadwick.Database.Models
{
    public class CsvProcessorJobs
    {
        [Key]
        public int CsvId { get; set; }
        public CommitProcessorJobs CommitJob { get; set; }
        public string FileName { get; set; }
        public DateTime Finished { get; set; }
        public string Status { get; set; }
        public DateTime Started { get; set; }


        public CsvProcessorJobs()
        {
            Started = DateTime.UtcNow;
        }
    }
}