using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Housekeeping
    {
        [Key]
        public int HousekeepingId { get; set; }

        [ForeignKey("Room")]
        public int? RoomId { get; set; }
        public virtual Room Room { get; set; }

        [Required, StringLength(200)]
        public string TaskDescription { get; set; }

        [Required]
        public int AssignedStaffId { get; set; }

        [Required]
        public DateTime TaskDate { get; set; } = DateTime.Now;

        public TimeSpan? CompletedTime { get; set; }

        [StringLength(50)]
        public string Status { get; set; } = "Pending";
    }
}