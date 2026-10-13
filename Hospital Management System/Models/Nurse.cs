using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Nurse
    {
        [Key]
        public int NurseId { get; set; }

        [Required, StringLength(100)]
        public string FullName { get; set; }

        [StringLength(100)]
        public string Department { get; set; }

        [Required, Phone]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [ForeignKey("Ward")]
        public int? WardId { get; set; }
        public virtual Ward Ward { get; set; }

        [StringLength(50)]
        public string ShiftType { get; set; }

        public DateTime JoiningDate { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;
    }
}