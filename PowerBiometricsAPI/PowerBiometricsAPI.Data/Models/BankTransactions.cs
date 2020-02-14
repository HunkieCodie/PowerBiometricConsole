using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class BankTransactions
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string BankTransactionId { get; set; }
        public string BankDocumentNumber { get; set; }
        public string GlbankAccount1 { get; set; }
        public string GlbankAccount2 { get; set; }
        public string TransactionType { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? SystemDate { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public decimal? TransactionAmount { get; set; }
        public bool? BeginningBalance { get; set; }
        public string Reference { get; set; }
        public bool? Posted { get; set; }
        public bool? Cleared { get; set; }
        public string Notes { get; set; }
        public string BatchControlNumber { get; set; }
        public decimal? BatchControlTotal { get; set; }
        public string Signature { get; set; }
        public string SignaturePassword { get; set; }
        public string SupervisorSignature { get; set; }
        public string SupervisorPassword { get; set; }
        public string ManagerSignature { get; set; }
        public string ManagerPassword { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string EnteredBy { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string TransactionSource { get; set; }
        public string BranchCode { get; set; }
    }
}
