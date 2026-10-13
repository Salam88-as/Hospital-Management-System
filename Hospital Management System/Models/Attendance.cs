using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Attendance
    {
        [Key]
        public int AttendanceId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required, StringLength(50)]
        public string EmployeeType { get; set; }

        [Required]
        public DateTime AttendanceDate { get; set; } = DateTime.Now;

        public TimeSpan? CheckInTime { get; set; }
        public TimeSpan? CheckOutTime { get; set; }

        [Required, StringLength(50)]
        public string Status { get; set; }
    }
}