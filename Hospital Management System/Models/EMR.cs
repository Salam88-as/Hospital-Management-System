using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace HospitalManagementSystem.Models
{
    public class EMR
    {
        [Key]
        public int EMRId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        [Required]
        public DateTime RecordDate { get; set; } = DateTime.Now;

        [StringLength(1000)]
        public string MedicalHistory { get; set; }

        [StringLength(1000)]
        public string Allergies { get; set; }

        [StringLength(1000)]
        public string ChronicConditions { get; set; }

        [StringLength(1000)]
        public string Notes { get; set; }

        public string AttachmentPath { get; set; }
    }
}