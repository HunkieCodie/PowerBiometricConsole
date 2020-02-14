using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollPeriodDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public DateTime Period { get; set; }
        public string EmployeeId { get; set; }
        public double? NetPay { get; set; }
        public double? GrossDeduction { get; set; }
        public double? GrossPay { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string EmployeeName { get; set; }
        public string BranchCode { get; set; }
    }
}
