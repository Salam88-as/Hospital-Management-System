using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class FeedbackComplaint
    {
        [Key]
        public int FeedbackId { get; set; }

        [ForeignKey("Patient")]
        public int? PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [Required, StringLength(50)]
        public string Type { get; set; }

        [Required, StringLength(150)]
        public string Subject { get; set; }

        [Required, StringLength(1000)]
        public string Description { get; set; }

        public int? Rating { get; set; }

        public DateTime SubmittedOn { get; set; } = DateTime.Now;

        [StringLength(50)]
        public string Status { get; set; } = "Open";

        [StringLength(1000)]
        public string ResolutionNotes { get; set; }
    }
}