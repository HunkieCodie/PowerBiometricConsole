using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class ApmemoBatchHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string BatchNumber { get; set; }
        public string TransactionTypeId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? SystemDate { get; set; }
        public string Reference { get; set; }
        public string Notes { get; set; }
        public bool? Memorize { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public double? TotalDebit { get; set; }
        public double? TotalCredit { get; set; }
        public double? BalanceAmount { get; set; }
        public string EnteredBy { get; set; }
        public bool? Cleared { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public bool? Posted { get; set; }
        public DateTime? PostedDate { get; set; }
        public string PostedBy { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
