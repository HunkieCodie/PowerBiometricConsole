using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollRatableWeeklyHeaderHistory
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string WeekId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime Period { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public decimal? Total { get; set; }
        public bool? Cleared { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? EnteredDate { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public bool? Posted { get; set; }
        public string PostedBy { get; set; }
        public DateTime? PostedDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? Taxable { get; set; }
        public string BranchCode { get; set; }
    }
}
