using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class BankReconciliationSummaryTemp
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string BankRecId { get; set; }
        public string GlbankAccount { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public DateTime? BankRecCutoffDate { get; set; }
        public decimal? BankRecEndingBalance { get; set; }
        public decimal? BankRecServiceCharge { get; set; }
        public string GlserviceChargeAccount { get; set; }
        public decimal? BankRecIntrest { get; set; }
        public string GlinterestAccount { get; set; }
        public decimal? BankRecAdjustment { get; set; }
        public string GladjustmentAccount { get; set; }
        public decimal? BankRecOtherCharges { get; set; }
        public string GlotherChargesAccount { get; set; }
        public decimal? BankRecCreditTotal { get; set; }
        public decimal? BankRecDebitTotal { get; set; }
        public decimal? BankRecCreditOs { get; set; }
        public decimal? BankRecDebitOs { get; set; }
        public decimal? BankRecStartingBalance { get; set; }
        public decimal? BankRecBookBalance { get; set; }
        public decimal? BankRecDifference { get; set; }
        public decimal? BankRecEndingBookBalance { get; set; }
        public decimal? BankRecStartingBookBalance { get; set; }
        public string Notes { get; set; }
        public DateTime? CreationDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
