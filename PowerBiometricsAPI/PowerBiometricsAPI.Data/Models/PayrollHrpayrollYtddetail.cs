using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollYtddetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public string PayTypeId { get; set; }
        public DateTime? LastUpdatedPeriod { get; set; }
        public double? CummulativeBalance { get; set; }
        public double? Utilized { get; set; }
        public double? Balance { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public double? CummulativeDays { get; set; }
        public double? UtilizedDays { get; set; }
        public double? BalanceDays { get; set; }
        public string AttrId { get; set; }
        public string BranchCode { get; set; }
    }
}
