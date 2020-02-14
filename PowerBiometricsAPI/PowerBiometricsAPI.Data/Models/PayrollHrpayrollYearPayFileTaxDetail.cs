using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollYearPayFileTaxDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public DateTime TranDate { get; set; }
        public double? AnnualGross { get; set; }
        public double? TotalFreepay { get; set; }
        public double? TotalTaxableIncome { get; set; }
        public double? AnnualTaxAmount { get; set; }
        public double? MonthlyTaxAmount { get; set; }
        public double? TaxRefund { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public string BranchCode { get; set; }
    }
}
