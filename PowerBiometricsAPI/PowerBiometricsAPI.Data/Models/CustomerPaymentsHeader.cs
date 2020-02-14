using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class CustomerPaymentsHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string CustomerPaymentId { get; set; }
        public string CustomerPaymentTypeId { get; set; }
        public string CustomerPaymentClassId { get; set; }
        public string CheckNumber { get; set; }
        public string CustomerId { get; set; }
        public bool? Memorize { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? SystemDate { get; set; }
        public DateTime? DueToDate { get; set; }
        public DateTime? OrderDate { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? UnAppliedAmount { get; set; }
        public string GlbankAccount { get; set; }
        public string BankId { get; set; }
        public string Status { get; set; }
        public bool? Nsf { get; set; }
        public string Notes { get; set; }
        public decimal? CreditAmount { get; set; }
        public bool? Cleared { get; set; }
        public bool? Posted { get; set; }
        public bool? Reconciled { get; set; }
        public bool? Deposited { get; set; }
        public string HeaderMemo1 { get; set; }
        public string HeaderMemo2 { get; set; }
        public string HeaderMemo3 { get; set; }
        public string HeaderMemo4 { get; set; }
        public string HeaderMemo5 { get; set; }
        public string HeaderMemo6 { get; set; }
        public string HeaderMemo7 { get; set; }
        public string HeaderMemo8 { get; set; }
        public string HeaderMemo9 { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
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
        public bool? Void { get; set; }
        public bool? AuditCheck { get; set; }
        public string AuditComments { get; set; }
        public string AuditedBy { get; set; }
        public DateTime? AuditedDate { get; set; }
        public string IssuedBy { get; set; }
        public bool? Released { get; set; }
        public string ReleasedComments { get; set; }
        public string ReleasedBy { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public string CustomerName { get; set; }
        public string BranchCode { get; set; }
    }
}
