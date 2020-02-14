using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class EdireceiptsHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ReceiptId { get; set; }
        public string ReceiptTypeId { get; set; }
        public string ReceiptClassId { get; set; }
        public string EdidirectionTypeId { get; set; }
        public string EdidocumentTypeId { get; set; }
        public bool? Ediopen { get; set; }
        public string CheckNumber { get; set; }
        public string CustomerId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? UnAppliedAmount { get; set; }
        public string GlbankAccount { get; set; }
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
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
