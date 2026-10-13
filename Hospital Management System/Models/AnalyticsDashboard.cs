using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class AnalyticsDashboard
    {
        [Key]
        public int AnalyticsId { get; set; }

        [Required, StringLength(150)]
        public string MetricName { get; set; }

        [Required]
        public decimal MetricValue { get; set; }

        [StringLength(50)]
        public string MetricUnit { get; set; }

        [Required, StringLength(50)]
        public string Category { get; set; }

        public DateTime RecordedDate { get; set; } = DateTime.Now;

        [StringLength(20)]
        public string Period { get; set; }
    }
}