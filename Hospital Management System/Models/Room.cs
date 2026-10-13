using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }

        [Required]
        [ForeignKey("Ward")]
        public int WardId { get; set; }
        public virtual Ward Ward { get; set; }

        [Required, StringLength(20)]
        public string RoomNumber { get; set; }

        [Required, StringLength(50)]
        public string RoomType { get; set; }

        public int BedCapacity { get; set; }

        public int OccupiedBeds { get; set; }

        public decimal DailyCharges { get; set; }

        [StringLength(50)]
        public string Status { get; set; } = "Available";
    }
}