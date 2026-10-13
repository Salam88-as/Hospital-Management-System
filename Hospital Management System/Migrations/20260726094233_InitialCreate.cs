using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hospital_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnalyticsDashboards",
                columns: table => new
                {
                    AnalyticsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MetricName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    MetricValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MetricUnit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RecordedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Period = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalyticsDashboards", x => x.AnalyticsId);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    AttendanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AttendanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckInTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    CheckOutTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.AttendanceId);
                });

            migrationBuilder.CreateTable(
                name: "AuditLogs",
                columns: table => new
                {
                    AuditLogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ActionType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EntityName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    EntityId = table.Column<int>(type: "int", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLogs", x => x.AuditLogId);
                });

            migrationBuilder.CreateTable(
                name: "BloodBanks",
                columns: table => new
                {
                    BloodUnitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BloodGroup = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    UnitsAvailable = table.Column<int>(type: "int", nullable: false),
                    DonorName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DonorContact = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CollectionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodBanks", x => x.BloodUnitId);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperienceYears = table.Column<int>(type: "int", nullable: false),
                    ConsultationFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorId);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    InventoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    QuantityInStock = table.Column<int>(type: "int", nullable: false),
                    ReorderLevel = table.Column<int>(type: "int", nullable: false),
                    SupplierName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    UnitCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LastRestockedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StorageLocation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.InventoryId);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipientUserId = table.Column<int>(type: "int", nullable: false),
                    RecipientType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationId);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    BloodGroup = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EmergencyContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyContactPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                });

            migrationBuilder.CreateTable(
                name: "Payrolls",
                columns: table => new
                {
                    PayrollId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PayMonth = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Allowances = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Deductions = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Bonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payrolls", x => x.PayrollId);
                });

            migrationBuilder.CreateTable(
                name: "Pharmacies",
                columns: table => new
                {
                    MedicineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicineName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BatchNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ReorderLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pharmacies", x => x.MedicineId);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    ReportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ReportType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GeneratedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GeneratedByUserId = table.Column<int>(type: "int", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.ReportId);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    StaffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Department = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.StaffId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Wards",
                columns: table => new
                {
                    WardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WardName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WardType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TotalBeds = table.Column<int>(type: "int", nullable: false),
                    AvailableBeds = table.Column<int>(type: "int", nullable: false),
                    FloorNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wards", x => x.WardId);
                });

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    ShiftId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShiftName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ShiftDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.ShiftId);
                    table.ForeignKey(
                        name: "FK_Shifts_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppointmentTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Billings",
                columns: table => new
                {
                    BillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    BillDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConsultationCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RoomCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MedicineCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LabCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OtherCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PaymentMethod = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Billings", x => x.BillId);
                    table.ForeignKey(
                        name: "FK_Billings_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DietNutritions",
                columns: table => new
                {
                    DietPlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    MealType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DietDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DietaryRestrictions = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrescribedBy = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietNutritions", x => x.DietPlanId);
                    table.ForeignKey(
                        name: "FK_DietNutritions_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Emergencies",
                columns: table => new
                {
                    EmergencyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    ArrivalTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TriageLevel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ChiefComplaint = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ActionTaken = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emergencies", x => x.EmergencyId);
                    table.ForeignKey(
                        name: "FK_Emergencies_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Emergencies_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EMRs",
                columns: table => new
                {
                    EMRId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicalHistory = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Allergies = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ChronicConditions = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    AttachmentPath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMRs", x => x.EMRId);
                    table.ForeignKey(
                        name: "FK_EMRs_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EMRs_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FeedbackComplaints",
                columns: table => new
                {
                    FeedbackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    SubmittedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ResolutionNotes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackComplaints", x => x.FeedbackId);
                    table.ForeignKey(
                        name: "FK_FeedbackComplaints_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Insurances",
                columns: table => new
                {
                    InsuranceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    ProviderName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PolicyNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CoverageAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PolicyStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PolicyEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClaimStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClaimedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurances", x => x.InsuranceId);
                    table.ForeignKey(
                        name: "FK_Insurances_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IRs",
                columns: table => new
                {
                    IRId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    ReportType = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ReportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Findings = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Impression = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ReportFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IRs", x => x.IRId);
                    table.ForeignKey(
                        name: "FK_IRs_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IRs_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Laboratories",
                columns: table => new
                {
                    LabTestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    TestName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SampleCollectedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResultDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResultValue = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    NormalRange = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TestFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laboratories", x => x.LabTestId);
                    table.ForeignKey(
                        name: "FK_Laboratories_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Laboratories_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OPDs",
                columns: table => new
                {
                    OPDId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    VisitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Symptoms = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Diagnosis = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ConsultationFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TokenNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OPDs", x => x.OPDId);
                    table.ForeignKey(
                        name: "FK_OPDs_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OPDs_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OperationTheatres",
                columns: table => new
                {
                    OperationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    OperationType = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ScheduledDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    OTRoomNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PreOpNotes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PostOpNotes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationTheatres", x => x.OperationId);
                    table.ForeignKey(
                        name: "FK_OperationTheatres_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OperationTheatres_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    PrescriptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    PrescriptionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicineName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Dosage = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Frequency = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Instructions = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.PrescriptionId);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Nurses",
                columns: table => new
                {
                    NurseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Department = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardId = table.Column<int>(type: "int", nullable: true),
                    ShiftType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurses", x => x.NurseId);
                    table.ForeignKey(
                        name: "FK_Nurses_Wards_WardId",
                        column: x => x.WardId,
                        principalTable: "Wards",
                        principalColumn: "WardId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WardId = table.Column<int>(type: "int", nullable: false),
                    RoomNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RoomType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BedCapacity = table.Column<int>(type: "int", nullable: false),
                    OccupiedBeds = table.Column<int>(type: "int", nullable: false),
                    DailyCharges = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_Rooms_Wards_WardId",
                        column: x => x.WardId,
                        principalTable: "Wards",
                        principalColumn: "WardId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Housekeepings",
                columns: table => new
                {
                    HousekeepingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomId = table.Column<int>(type: "int", nullable: true),
                    TaskDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AssignedStaffId = table.Column<int>(type: "int", nullable: false),
                    TaskDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletedTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Housekeepings", x => x.HousekeepingId);
                    table.ForeignKey(
                        name: "FK_Housekeepings_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IPDs",
                columns: table => new
                {
                    IPDId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    WardId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    AdmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DischargeDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdmissionReason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AdvancePayment = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPDs", x => x.IPDId);
                    table.ForeignKey(
                        name: "FK_IPDs_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IPDs_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IPDs_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IPDs_Wards_WardId",
                        column: x => x.WardId,
                        principalTable: "Wards",
                        principalColumn: "WardId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DischargeSummaries",
                columns: table => new
                {
                    DischargeSummaryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IPDId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    DischargeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiagnosisSummary = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    TreatmentGiven = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    FollowUpInstructions = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DischargeMedications = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ConditionOnDischarge = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DischargeSummaries", x => x.DischargeSummaryId);
                    table.ForeignKey(
                        name: "FK_DischargeSummaries_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DischargeSummaries_IPDs_IPDId",
                        column: x => x.IPDId,
                        principalTable: "IPDs",
                        principalColumn: "IPDId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DischargeSummaries_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Billings_PatientId",
                table: "Billings",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_DietNutritions_PatientId",
                table: "DietNutritions",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_DischargeSummaries_DoctorId",
                table: "DischargeSummaries",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_DischargeSummaries_IPDId",
                table: "DischargeSummaries",
                column: "IPDId");

            migrationBuilder.CreateIndex(
                name: "IX_DischargeSummaries_PatientId",
                table: "DischargeSummaries",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Emergencies_DoctorId",
                table: "Emergencies",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Emergencies_PatientId",
                table: "Emergencies",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_EMRs_DoctorId",
                table: "EMRs",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_EMRs_PatientId",
                table: "EMRs",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedbackComplaints_PatientId",
                table: "FeedbackComplaints",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Housekeepings_RoomId",
                table: "Housekeepings",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Insurances_PatientId",
                table: "Insurances",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_IPDs_DoctorId",
                table: "IPDs",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_IPDs_PatientId",
                table: "IPDs",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_IPDs_RoomId",
                table: "IPDs",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_IPDs_WardId",
                table: "IPDs",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_IRs_DoctorId",
                table: "IRs",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_IRs_PatientId",
                table: "IRs",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Laboratories_DoctorId",
                table: "Laboratories",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Laboratories_PatientId",
                table: "Laboratories",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_WardId",
                table: "Nurses",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_OPDs_DoctorId",
                table: "OPDs",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_OPDs_PatientId",
                table: "OPDs",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationTheatres_DoctorId",
                table: "OperationTheatres",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationTheatres_PatientId",
                table: "OperationTheatres",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_DoctorId",
                table: "Prescriptions",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_PatientId",
                table: "Prescriptions",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_WardId",
                table: "Rooms",
                column: "WardId");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_DoctorId",
                table: "Shifts",
                column: "DoctorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnalyticsDashboards");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "AuditLogs");

            migrationBuilder.DropTable(
                name: "Billings");

            migrationBuilder.DropTable(
                name: "BloodBanks");

            migrationBuilder.DropTable(
                name: "DietNutritions");

            migrationBuilder.DropTable(
                name: "DischargeSummaries");

            migrationBuilder.DropTable(
                name: "Emergencies");

            migrationBuilder.DropTable(
                name: "EMRs");

            migrationBuilder.DropTable(
                name: "FeedbackComplaints");

            migrationBuilder.DropTable(
                name: "Housekeepings");

            migrationBuilder.DropTable(
                name: "Insurances");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "IRs");

            migrationBuilder.DropTable(
                name: "Laboratories");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Nurses");

            migrationBuilder.DropTable(
                name: "OPDs");

            migrationBuilder.DropTable(
                name: "OperationTheatres");

            migrationBuilder.DropTable(
                name: "Payrolls");

            migrationBuilder.DropTable(
                name: "Pharmacies");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "IPDs");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Wards");
        }
    }
}
