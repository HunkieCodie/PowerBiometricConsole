using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollEmployeesTimesheetDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string TimePeriod { get; set; }
        public string TimePeriodDetailId { get; set; }
        public DateTime? PeriodStart { get; set; }
        public DateTime? PeriodEnd { get; set; }
        public double? Time { get; set; }
        public string TimeUnits { get; set; }
        public string EventId { get; set; }
        public string Description { get; set; }
        public string CustomerId { get; set; }
        public string ProjectId { get; set; }
        public string EmployeeTaskId { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string EmployeeId { get; set; }
        public string BranchCode { get; set; }
    }
}
