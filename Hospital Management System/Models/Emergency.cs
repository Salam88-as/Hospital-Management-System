using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace HospitalManagementSystem.Models
{
    public class Emergency
    {
        [Key]
        public int EmergencyId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        [Required]
        public DateTime ArrivalTime { get; set; } = DateTime.Now;

        [Required, StringLength(50)]
        public string TriageLevel { get; set; }

        [StringLength(500)]
        public string ChiefComplaint { get; set; }

        [StringLength(500)]
        public string ActionTaken { get; set; }

        [StringLength(50)]
        public string Status { get; set; } = "In Treatment";
    }
}