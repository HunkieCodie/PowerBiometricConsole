using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollEmployeePfadetails
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public string Pfaid { get; set; }
        public DateTime TranDate { get; set; }
        public bool Employer { get; set; }
        public double? Pfapercent { get; set; }
        public double? Amount { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string Pfano { get; set; }
        public string BranchCode { get; set; }
    }
}
