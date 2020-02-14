using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollOvertimeDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public string OvertimeTypeId { get; set; }
        public double? OvertimeRate { get; set; }
        public double? Duration { get; set; }
        public double? Amount { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? Taxable { get; set; }
        public string BranchCode { get; set; }
    }
}
