using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace HospitalManagementSystem.Models
{
    public class IR
    {
        [Key]
        public int IRId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        [Required, StringLength(150)]
        public string ReportType { get; set; }

        [Required]
        public DateTime ReportDate { get; set; } = DateTime.Now;

        [StringLength(1000)]
        public string Findings { get; set; }

        [StringLength(1000)]
        public string Impression { get; set; }

        public string ReportFilePath { get; set; }

        [StringLength(50)]
        public string Status { get; set; } = "Pending";
    }
}