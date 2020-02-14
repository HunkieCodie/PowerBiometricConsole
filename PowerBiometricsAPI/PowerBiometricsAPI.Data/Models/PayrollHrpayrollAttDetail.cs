using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollAttDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public DateTime AttendanceDate { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? TimeIn { get; set; }
        public bool? Absent { get; set; }
        public string Remarks { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public double? LatePeriod { get; set; }
        public DateTime? Period { get; set; }
        public string ShiftType { get; set; }
        public DateTime? ExpectedTimeIn { get; set; }
        public string EmployeeName { get; set; }
        public string BranchCode { get; set; }
    }
}
