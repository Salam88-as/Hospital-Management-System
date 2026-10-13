using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }

        [Required, StringLength(100)]
        public string FullName { get; set; }

        [Required, StringLength(100)]
        public string Designation { get; set; }

        [StringLength(100)]
        public string Department { get; set; }

        [Required, Phone]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public decimal Salary { get; set; }

        public DateTime JoiningDate { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;
    }
}