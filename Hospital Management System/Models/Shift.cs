using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Shift
    {
        [Key]
        public int ShiftId { get; set; }

        [ForeignKey("Doctor")]
        public int? DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required, StringLength(50)]
        public string EmployeeType { get; set; }

        [Required, StringLength(50)]
        public string ShiftName { get; set; }

        [Required]
        public TimeSpan StartTime { get; set; }

        [Required]
        public TimeSpan EndTime { get; set; }

        [Required]
        public DateTime ShiftDate { get; set; }
    }
}