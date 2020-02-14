using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollLoanDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string LoanType { get; set; }
        public string EmployeeId { get; set; }
        public int? TotalPeriod { get; set; }
        public double? OutPeriod { get; set; }
        public decimal? TotalPrincipal { get; set; }
        public decimal? MonthlyPay { get; set; }
        public decimal? OutPay { get; set; }
        public decimal? IntMthPay { get; set; }
        public decimal? TotalPay { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? ActiveYn { get; set; }
        public bool? Cleared { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? EnteredDate { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public bool? Posted { get; set; }
        public string PostedBy { get; set; }
        public DateTime? PostedDate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? LiquidationDate { get; set; }
        public decimal? MonthlyPayWoint { get; set; }
        public string GlaccountNumber { get; set; }
        public bool? OnPayroll { get; set; }
        public int LoanId { get; set; }
        public string Description { get; set; }
        public string BranchCode { get; set; }
    }
}
