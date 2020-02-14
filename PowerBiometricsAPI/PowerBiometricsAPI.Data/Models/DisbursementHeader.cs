using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class DisbursementHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string DisbursementId { get; set; }
        public string DisbursementTypeId { get; set; }
        public string CheckNumber { get; set; }
        public bool? CheckPrinted { get; set; }
        public DateTime? CheckDate { get; set; }
        public bool? Paid { get; set; }
        public DateTime? DisbursementDate { get; set; }
        public bool? Memorize { get; set; }
        public string DisbursementClassId { get; set; }
        public string VendorId { get; set; }
        public DateTime? SystemDate { get; set; }
        public DateTime? DueToDate { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? UnAppliedAmount { get; set; }
        public string GlbankAccount { get; set; }
        public string BankId { get; set; }
        public string DisbursementStatus { get; set; }
        public bool? Void { get; set; }
        public string Notes { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public decimal? CreditAmount { get; set; }
        public bool? SelectedForDisbursement { get; set; }
        public DateTime? SelectedForDisbursementDate { get; set; }
        public bool? ApprovedForDisbursement { get; set; }
        public DateTime? ApprovedForDisbursementDate { get; set; }
        public bool? Cleared { get; set; }
        public string InvoiceNumber { get; set; }
        public bool? Posted { get; set; }
        public bool? Reconciled { get; set; }
        public bool? Credit { get; set; }
        public string ApprovedBy { get; set; }
        public string EnteredBy { get; set; }
        public string BatchControlNumber { get; set; }
        public decimal? BatchControlTotal { get; set; }
        public string Signature { get; set; }
        public string SignaturePassword { get; set; }
        public string SupervisorSignature { get; set; }
        public string SupervisorPassword { get; set; }
        public string ManagerSignature { get; set; }
        public string ManagerPassword { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string TaxGroupId { get; set; }
        public decimal? TaxAmount { get; set; }
        public string BranchCode { get; set; }
    }
}
