using Hospital_Management_System.Models;
using HospitalManagementSystem.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly HospitalManagementSystemDbContext _context;

        public HomeController(HospitalManagementSystemDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Top stat strip
            ViewBag.TotalPatients = await _context.Patients.CountAsync();
            ViewBag.TotalDoctors = await _context.Doctors.CountAsync();
            ViewBag.TodayAppointments = await _context.Appointments
                .CountAsync(a => a.AppointmentDate.Date == System.DateTime.Today);
            ViewBag.AdmittedPatients = await _context.IPDs.CountAsync(i => i.Status == "Admitted");
            ViewBag.PendingBills = await _context.Billings.CountAsync(b => b.PaymentStatus != "Paid");
            ViewBag.AvailableBeds = await _context.Rooms.SumAsync(r => (int?)(r.BedCapacity - r.OccupiedBeds)) ?? 0;

            // Every module count (for badges next to each nav link)
            ViewBag.CountPatient = await _context.Patients.CountAsync();
            ViewBag.CountAppointment = await _context.Appointments.CountAsync();
            ViewBag.CountOPD = await _context.OPDs.CountAsync();
            ViewBag.CountIPD = await _context.IPDs.CountAsync();
            ViewBag.CountEMR = await _context.EMRs.CountAsync();
            ViewBag.CountIR = await _context.IRs.CountAsync();
            ViewBag.CountPrescription = await _context.Prescriptions.CountAsync();
            ViewBag.CountDischargeSummary = await _context.DischargeSummaries.CountAsync();

            ViewBag.CountLaboratory = await _context.Laboratories.CountAsync();
            ViewBag.CountPharmacy = await _context.Pharmacies.CountAsync();
            ViewBag.CountBloodBank = await _context.BloodBanks.CountAsync();
            ViewBag.CountOperationTheatre = await _context.OperationTheatres.CountAsync();
            ViewBag.CountEmergency = await _context.Emergencies.CountAsync();

            ViewBag.CountDoctor = await _context.Doctors.CountAsync();
            ViewBag.CountNurse = await _context.Nurses.CountAsync();
            ViewBag.CountStaff = await _context.Staffs.CountAsync();
            ViewBag.CountAttendance = await _context.Attendances.CountAsync();
            ViewBag.CountShift = await _context.Shifts.CountAsync();

            ViewBag.CountWard = await _context.Wards.CountAsync();
            ViewBag.CountRoom = await _context.Rooms.CountAsync();
            ViewBag.CountInventory = await _context.Inventories.CountAsync();
            ViewBag.CountDietNutrition = await _context.DietNutritions.CountAsync();
            ViewBag.CountHousekeeping = await _context.Housekeepings.CountAsync();

            ViewBag.CountBilling = await _context.Billings.CountAsync();
            ViewBag.CountPayroll = await _context.Payrolls.CountAsync();
            ViewBag.CountInsurance = await _context.Insurances.CountAsync();

            ViewBag.CountReport = await _context.Reports.CountAsync();
            ViewBag.CountNotification = await _context.Notifications.CountAsync();
            ViewBag.CountAuditLog = await _context.AuditLogs.CountAsync();
            ViewBag.CountAnalyticsDashboard = await _context.AnalyticsDashboards.CountAsync();
            ViewBag.CountFeedbackComplaint = await _context.FeedbackComplaints.CountAsync();

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}