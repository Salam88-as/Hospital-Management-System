using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        [Required, StringLength(100)]
        public string FullName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required, StringLength(10)]
        public string Gender { get; set; }

        [StringLength(5)]
        public string BloodGroup { get; set; }

        [Required, Phone]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhone { get; set; }

        public DateTime RegisteredOn { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;

        // Navigation properties
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<OPD> OPDVisits { get; set; }
        public virtual ICollection<IPD> IPDAdmissions { get; set; }
        public virtual ICollection<EMR> MedicalRecords { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}