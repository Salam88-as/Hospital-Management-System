using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace HospitalManagementSystem.Models
{
    public class DischargeSummary
    {
        [Key]
        public int DischargeSummaryId { get; set; }

        [Required]
        [ForeignKey("IPD")]
        public int IPDId { get; set; }
        public virtual IPD IPD { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [Required]
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        [Required]
        public DateTime DischargeDate { get; set; } = DateTime.Now;

        [StringLength(1000)]
        public string DiagnosisSummary { get; set; }

        [StringLength(1000)]
        public string TreatmentGiven { get; set; }

        [StringLength(1000)]
        public string FollowUpInstructions { get; set; }

        [StringLength(500)]
        public string DischargeMedications { get; set; }

        [StringLength(50)]
        public string ConditionOnDischarge { get; set; }
    }
}