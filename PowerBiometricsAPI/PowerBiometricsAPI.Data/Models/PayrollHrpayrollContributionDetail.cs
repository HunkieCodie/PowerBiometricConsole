using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollContributionDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ContributionId { get; set; }
        public string EmployeeId { get; set; }
        public double? EmployeePercent { get; set; }
        public double? EmployerPercent { get; set; }
        public decimal? EmployeeAmount { get; set; }
        public decimal? EmployerAmount { get; set; }
        public string ContributionNumber { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
