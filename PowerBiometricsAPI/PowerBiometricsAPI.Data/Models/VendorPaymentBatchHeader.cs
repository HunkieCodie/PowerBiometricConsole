using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class VendorPaymentBatchHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PaymentId { get; set; }
        public string PaymentTypeId { get; set; }
        public string PaymentClassId { get; set; }
        public string CheckNumber { get; set; }
        public DateTime? CheckDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public bool? Memorize { get; set; }
        public DateTime? SystemDate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? UnAppliedAmount { get; set; }
        public string GlbankAccount { get; set; }
        public string BankId { get; set; }
        public bool? Void { get; set; }
        public string Notes { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public decimal? CreditAmount { get; set; }
        public bool? Cleared { get; set; }
        public string EnteredBy { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public bool? Posted { get; set; }
        public string PostedBy { get; set; }
        public DateTime? PostedDate { get; set; }
        public bool? AuditCheck { get; set; }
        public string AuditComments { get; set; }
        public string AuditedBy { get; set; }
        public DateTime? AuditedDate { get; set; }
        public bool? Released { get; set; }
        public string ReleasedComments { get; set; }
        public string ReleasedBy { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public string BatchControlNumber { get; set; }
        public decimal? BatchControlTotal { get; set; }
        public string Signature { get; set; }
        public string SignaturePassword { get; set; }
        public string SupervisorSignature { get; set; }
        public string SupervisorPassword { get; set; }
        public string ManagerSignature { get; set; }
        public string ManagerPassword { get; set; }
        public double? TaxAmount { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
