using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollChecks
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PayrollId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime? PayrollCheckDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? CheckPrinted { get; set; }
        public decimal? Amount { get; set; }
        public string GlemployeeCreditAccount { get; set; }
        public string CheckNumber { get; set; }
        public string CheckTypeId { get; set; }
        public string CurrencyId { get; set; }
        public bool? Apply { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
