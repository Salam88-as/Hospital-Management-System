using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class Billing
    {
        [Key]
        public int BillId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [Required]
        public DateTime BillDate { get; set; } = DateTime.Now;

        public decimal ConsultationCharges { get; set; }
        public decimal RoomCharges { get; set; }
        public decimal MedicineCharges { get; set; }
        public decimal LabCharges { get; set; }
        public decimal OtherCharges { get; set; }

        [NotMapped]
        public decimal TotalAmount => ConsultationCharges + RoomCharges + MedicineCharges + LabCharges + OtherCharges;

        public decimal AmountPaid { get; set; }

        public decimal AmountDue => TotalAmount - AmountPaid;

        [StringLength(50)]
        public string PaymentStatus { get; set; } = "Pending";

        [StringLength(50)]
        public string PaymentMethod { get; set; }
    }
}