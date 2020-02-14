using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollEmployeesCurrentlyOn
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public DateTime LoginDate { get; set; }
        public string EmployeeId { get; set; }
        public string Status { get; set; }
        public string EmployeeEmail { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string SessionId { get; set; }
        public string BranchCode { get; set; }
    }
}
