using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace HospitalManagementSystem.Models
{
    public class IPD
    {
        [Key]
        public int IPDId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [Required]
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        [ForeignKey("Ward")]
        public int WardId { get; set; }
        public virtual Ward Ward { get; set; }

        [ForeignKey("Room")]
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }

        [Required]
        public DateTime AdmissionDate { get; set; } = DateTime.Now;

        public DateTime? DischargeDate { get; set; }

        [StringLength(500)]
        public string AdmissionReason { get; set; }

        [StringLength(50)]
        public string Status { get; set; } = "Admitted";

        public decimal AdvancePayment { get; set; }
    }
}