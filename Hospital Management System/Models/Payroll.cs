using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalManagementSystem.Models
{
    public class Payroll
    {
        [Key]
        public int PayrollId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required, StringLength(50)]
        public string EmployeeType { get; set; }

        [Required, StringLength(20)]
        public string PayMonth { get; set; }

        public decimal BasicSalary { get; set; }
        public decimal Allowances { get; set; }
        public decimal Deductions { get; set; }
        public decimal Bonus { get; set; }

        public decimal NetSalary => BasicSalary + Allowances + Bonus - Deductions;

        public DateTime PaymentDate { get; set; }

        [StringLength(50)]
        public string Status { get; set; } = "Pending";
    }
}