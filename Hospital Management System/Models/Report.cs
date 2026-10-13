using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Report
    {
        [Key]
        public int ReportId { get; set; }

        [Required, StringLength(150)]
        public string ReportName { get; set; }

        [Required, StringLength(100)]
        public string ReportType { get; set; }

        public DateTime GeneratedOn { get; set; } = DateTime.Now;

        [Required]
        public int GeneratedByUserId { get; set; }

        public string FilePath { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}