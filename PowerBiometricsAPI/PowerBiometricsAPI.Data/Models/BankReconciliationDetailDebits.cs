using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class BankReconciliationDetailDebits
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string BankId { get; set; }
        public string BankTransactionId { get; set; }
        public string BankRecType { get; set; }
        public int BankRecLineNumber { get; set; }
        public string BankRecDocumentNumber { get; set; }
        public bool? BankRecCleared { get; set; }
        public DateTime? BankRecClearedDate { get; set; }
        public string BankRecDescription { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public decimal? BankRecAmount { get; set; }
        public string BankRecMemo { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
