using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace HospitalManagementSystem.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [Required]
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }

        [Required]
        public TimeSpan AppointmentTime { get; set; }

        [StringLength(50)]
        public string Status { get; set; } = "Scheduled";

        [StringLength(500)]
        public string Reason { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}