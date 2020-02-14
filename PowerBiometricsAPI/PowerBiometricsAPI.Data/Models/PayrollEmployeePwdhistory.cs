using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollEmployeePwdhistory
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public long TransactionId { get; set; }
        public string EmployeePassword { get; set; }
        public string EmployeePasswordOld { get; set; }
        public DateTime? EmployeePasswordDate { get; set; }
        public string ChangedBy { get; set; }
        public string Ipaddress { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
