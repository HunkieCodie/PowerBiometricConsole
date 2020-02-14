using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class EdistatementsHistory
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string BankId { get; set; }
        public string BankTransactionId { get; set; }
        public DateTime? SystemDate { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public string TransactionAccount { get; set; }
        public string TransactionDescription { get; set; }
        public string TransactionReference { get; set; }
        public decimal? TransactionAmount { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public string TransactionCodeA { get; set; }
        public string TransactionCodeB { get; set; }
        public string TransactionCodeC { get; set; }
        public decimal? BeginningBalance { get; set; }
        public decimal? EndingBalance { get; set; }
        public string DebitCredit { get; set; }
        public bool? Cleared { get; set; }
        public bool? Reconciled { get; set; }
        public string RelatedDocumentNumber { get; set; }
        public string Notes { get; set; }
        public string BranchCode { get; set; }
    }
}
