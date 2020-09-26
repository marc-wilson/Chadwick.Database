using System;
using System.ComponentModel.DataAnnotations;

namespace Chadwick.Database.Models
{
    public class CsvProcessorJob
    {
        [Key]
        public int Id { get; set; }
        public CommitProcessorJob CommitJob { get; set; }
        public string FileName { get; set; }
        public DateTime Finished { get; set; }
        public string Status { get; set; }
        public DateTime Started { get; set; }


        public CsvProcessorJob()
        {
            Started = DateTime.UtcNow;
        }
    }
}