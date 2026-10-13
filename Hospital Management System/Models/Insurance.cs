using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Insurance
    {
        [Key]
        public int InsuranceId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [Required, StringLength(150)]
        public string ProviderName { get; set; }

        [Required, StringLength(100)]
        public string PolicyNumber { get; set; }

        public decimal CoverageAmount { get; set; }

        public DateTime PolicyStartDate { get; set; }
        public DateTime PolicyEndDate { get; set; }

        [StringLength(50)]
        public string ClaimStatus { get; set; } = "Not Claimed";

        public decimal ClaimedAmount { get; set; }
    }
}