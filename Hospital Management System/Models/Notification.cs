using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Notification
    {
        [Key]
        public int NotificationId { get; set; }

        [Required]
        public int RecipientUserId { get; set; }

        [Required, StringLength(50)]
        public string RecipientType { get; set; }

        [Required, StringLength(200)]
        public string Title { get; set; }

        [Required, StringLength(1000)]
        public string Message { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public bool IsRead { get; set; } = false;

        [StringLength(50)]
        public string Priority { get; set; } = "Normal";
    }
}