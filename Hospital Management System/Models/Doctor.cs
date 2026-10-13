using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        [Required, StringLength(100)]
        public string FullName { get; set; }

        [Required, StringLength(100)]
        public string Specialization { get; set; }

        [StringLength(100)]
        public string Qualification { get; set; }

        [Required, Phone]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public int ExperienceYears { get; set; }

        public decimal ConsultationFee { get; set; }

        public DateTime JoiningDate { get; set; } = DateTime.Now;

        public bool IsAvailable { get; set; } = true;

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Shift> Shifts { get; set; }
    }
}