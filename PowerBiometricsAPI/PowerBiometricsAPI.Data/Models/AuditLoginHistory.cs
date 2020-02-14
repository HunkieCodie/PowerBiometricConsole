using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class AuditLoginHistory
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public decimal AuditId { get; set; }
        public DateTime? LoginDateTime { get; set; }
        public string MachineName { get; set; }
        public string Ipaddress { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public int? LoginType { get; set; }
        public string BranchCode { get; set; }
    }
}
