using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class BankReconciliationHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string BankRecId { get; set; }
        public string BankId { get; set; }
        public DateTime? BankRecEndDate { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public string GlbankAccount { get; set; }
        public decimal? BankRecEndingBalance { get; set; }
        public string BankRecNotes { get; set; }
        public bool? Posted { get; set; }
        public DateTime? PostedDate { get; set; }
        public string PostedBy { get; set; }
        public decimal? BankRecServiceCharge { get; set; }
        public string GlserviceChargeAccount { get; set; }
        public decimal? BankRecIntrest { get; set; }
        public string GlinterestAccount { get; set; }
        public decimal? BankRecOtherCharges { get; set; }
        public string GlotherChargesAccount { get; set; }
        public decimal? BankRecAdjustment { get; set; }
        public string GladjustmentAccount { get; set; }
        public decimal? TotalCredit { get; set; }
        public decimal? TotalReconciledCredit { get; set; }
        public decimal? TotalUnReconciledCredit { get; set; }
        public decimal? TotalOustandingCredit { get; set; }
        public decimal? TotalDebit { get; set; }
        public decimal? TotalReconciledDebit { get; set; }
        public decimal? TotalUnReconciledDebit { get; set; }
        public decimal? TotalOustandingDebit { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
