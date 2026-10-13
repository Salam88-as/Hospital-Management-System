using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace HospitalManagementSystem.Models
{
    public class Prescription
    {
        [Key]
        public int PrescriptionId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [Required]
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        [Required]
        public DateTime PrescriptionDate { get; set; } = DateTime.Now;

        [Required, StringLength(200)]
        public string MedicineName { get; set; }

        [StringLength(100)]
        public string Dosage { get; set; }

        [StringLength(100)]
        public string Frequency { get; set; }

        [StringLength(100)]
        public string Duration { get; set; }

        [StringLength(500)]
        public string Instructions { get; set; }
    }
}