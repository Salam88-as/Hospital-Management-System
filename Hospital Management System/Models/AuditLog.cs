using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class AuditLog
    {
        [Key]
        public int AuditLogId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required, StringLength(100)]
        public string UserName { get; set; }

        [Required, StringLength(100)]
        public string ActionType { get; set; }

        [Required, StringLength(150)]
        public string EntityName { get; set; }

        public int? EntityId { get; set; }

        [StringLength(1000)]
        public string Details { get; set; }

        public DateTime Timestamp { get; set; } = DateTime.Now;

        [StringLength(50)]
        public string IPAddress { get; set; }
    }
}