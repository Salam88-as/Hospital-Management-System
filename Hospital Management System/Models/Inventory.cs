using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }

        [Required, StringLength(200)]
        public string ItemName { get; set; }

        [StringLength(100)]
        public string Category { get; set; }

        [Required]
        public int QuantityInStock { get; set; }

        public int ReorderLevel { get; set; }

        [StringLength(150)]
        public string SupplierName { get; set; }

        public decimal UnitCost { get; set; }

        public DateTime LastRestockedDate { get; set; } = DateTime.Now;

        [StringLength(100)]
        public string StorageLocation { get; set; }
    }
}