using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class BloodBank
    {
        [Key]
        public int BloodUnitId { get; set; }

        [Required, StringLength(5)]
        public string BloodGroup { get; set; }

        [Required]
        public int UnitsAvailable { get; set; }

        [StringLength(150)]
        public string DonorName { get; set; }

        [StringLength(15)]
        public string DonorContact { get; set; }

        public DateTime CollectionDate { get; set; } = DateTime.Now;

        public DateTime ExpiryDate { get; set; }

        [StringLength(50)]
        public string Status { get; set; } = "Available";
    }
}