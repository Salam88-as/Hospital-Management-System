using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace HospitalManagementSystem.Models
{
    public class OPD
    {
        [Key]
        public int OPDId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [Required]
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        [Required]
        public DateTime VisitDate { get; set; } = DateTime.Now;

        [StringLength(500)]
        public string Symptoms { get; set; }

        [StringLength(500)]
        public string Diagnosis { get; set; }

        public decimal ConsultationFee { get; set; }

        [StringLength(50)]
        public string TokenNumber { get; set; }

        [StringLength(50)]
        public string Status { get; set; } = "Waiting";
    }
}