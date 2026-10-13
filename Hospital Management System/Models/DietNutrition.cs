using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models
{
    public class DietNutrition
    {
        [Key]
        public int DietPlanId { get; set; }

        [Required]
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        [Required, StringLength(50)]
        public string MealType { get; set; }

        [Required, StringLength(500)]
        public string DietDescription { get; set; }

        [StringLength(200)]
        public string DietaryRestrictions { get; set; }

        public DateTime EffectiveDate { get; set; } = DateTime.Now;

        [StringLength(150)]
        public string PrescribedBy { get; set; }
    }
}