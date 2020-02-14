using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollRoster
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime PeriodIn { get; set; }
        public DateTime? PeriodOut { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? Sync { get; set; }
        public bool? ActiveYn { get; set; }
        public bool? Closed { get; set; }
        public string ShiftType { get; set; }
        public string BranchCode { get; set; }
    }
}
