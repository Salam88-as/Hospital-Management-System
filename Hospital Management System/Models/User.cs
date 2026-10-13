using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required, StringLength(100)]
        public string FullName { get; set; }

        [Required, EmailAddress, StringLength(150)]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required, StringLength(50)]
        public string Role { get; set; } = "Admin"; // Admin, Doctor, Nurse, Staff, Patient

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;
    }
}