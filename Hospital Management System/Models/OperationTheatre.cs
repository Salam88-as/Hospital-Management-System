using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace HospitalManagementSystem.Models
{
    public class OperationTheatre
    {
        [Key]
        public int OperationId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [Required]
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        [Required, StringLength(150)]
        public string OperationType { get; set; }

        [Required]
        public DateTime ScheduledDate { get; set; }

        public TimeSpan StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }

        [StringLength(50)]
        public string OTRoomNumber { get; set; }

        [StringLength(500)]
        public string PreOpNotes { get; set; }

        [StringLength(500)]
        public string PostOpNotes { get; set; }

        [StringLength(50)]
        public string Status { get; set; } = "Scheduled";
    }
}