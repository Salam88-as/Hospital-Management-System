using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Pharmacy
    {
        [Key]
        public int MedicineId { get; set; }

        [Required, StringLength(200)]
        public string MedicineName { get; set; }

        [StringLength(100)]
        public string Category { get; set; }

        [StringLength(100)]
        public string Manufacturer { get; set; }

        [Required]
        public int StockQuantity { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        public DateTime ExpiryDate { get; set; }

        [StringLength(50)]
        public string BatchNumber { get; set; }

        public int ReorderLevel { get; set; }
    }
}