using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollRatableWeeklyDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PayTypeId { get; set; }
        public string WeekId { get; set; }
        public string EmployeeId { get; set; }
        public string PayTypeDetailId { get; set; }
        public double? PayRate { get; set; }
        public double? Duration { get; set; }
        public double? Amount { get; set; }
        public bool? Taxable { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string CostCenterId { get; set; }
        public string CostCenterId2 { get; set; }
        public string BasisId { get; set; }
        public string BranchCode { get; set; }
    }
}
