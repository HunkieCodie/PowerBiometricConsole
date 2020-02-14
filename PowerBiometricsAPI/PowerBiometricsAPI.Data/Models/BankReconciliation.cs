using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class BankReconciliation
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string BankId { get; set; }
        public DateTime? BankRecStartDate { get; set; }
        public DateTime? BankRecEndDate { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public string GlbankAccount { get; set; }
        public decimal? BankRecEndingBalance { get; set; }
        public decimal? BankRecServiceCharge { get; set; }
        public string GlserviceChargeAccount { get; set; }
        public decimal? BankRecIntrest { get; set; }
        public string GlinterestAccount { get; set; }
        public decimal? BankRecOtherCharges { get; set; }
        public string GlotherChargesAccount { get; set; }
        public decimal? BankRecAdjustment { get; set; }
        public string GladjustmentAccount { get; set; }
        public string BankRecNotes { get; set; }
        public string Signature { get; set; }
        public string SignaturePassword { get; set; }
        public string SupervisorSignature { get; set; }
        public string SupervisorPassword { get; set; }
        public string ManagerSignature { get; set; }
        public string ManagerPassword { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
