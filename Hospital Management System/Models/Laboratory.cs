using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Laboratory
    {
        [Key]
        public int LabTestId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        [Required, StringLength(150)]
        public string TestName { get; set; }

        public DateTime SampleCollectedOn { get; set; } = DateTime.Now;
        public DateTime? ResultDate { get; set; }

        [StringLength(1000)]
        public string ResultValue { get; set; }

        [StringLength(200)]
        public string NormalRange { get; set; }

        public decimal TestFee { get; set; }

        [StringLength(50)]
        public string Status { get; set; } = "Pending";
    }
}