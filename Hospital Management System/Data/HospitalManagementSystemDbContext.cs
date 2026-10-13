using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Data
{
    public class HospitalManagementSystemDbContext : DbContext
    {
        public HospitalManagementSystemDbContext(DbContextOptions<HospitalManagementSystemDbContext> options)
            : base(options)
        {
        }

        // Patient Management
        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<OPD> OPDs { get; set; }
        public DbSet<IPD> IPDs { get; set; }
        public DbSet<EMR> EMRs { get; set; }
        public DbSet<IR> IRs { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<DischargeSummary> DischargeSummaries { get; set; }

        // Clinical Services
        public DbSet<Laboratory> Laboratories { get; set; }
        public DbSet<Pharmacy> Pharmacies { get; set; }
        public DbSet<BloodBank> BloodBanks { get; set; }
        public DbSet<OperationTheatre> OperationTheatres { get; set; }
        public DbSet<Emergency> Emergencies { get; set; }

        // Human Resources
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Shift> Shifts { get; set; }

        // Facility & Operations
        public DbSet<Ward> Wards { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<DietNutrition> DietNutritions { get; set; }
        public DbSet<Housekeeping> Housekeepings { get; set; }

        // Finance
        public DbSet<Billing> Billings { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<Insurance> Insurances { get; set; }

        // Administration
        public DbSet<Report> Reports { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<AnalyticsDashboard> AnalyticsDashboards { get; set; }
        public DbSet<FeedbackComplaint> FeedbackComplaints { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Har entity jo Patient/Doctor ko multiple baar reference karti hai,
            // us pe cascade delete restrict kar dete hain taake conflict na ho
            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}