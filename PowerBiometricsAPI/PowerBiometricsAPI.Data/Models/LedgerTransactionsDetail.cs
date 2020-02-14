using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class LedgerTransactionsDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string GltransactionNumber { get; set; }
        public decimal GltransactionNumberDetail { get; set; }
        public string GltransactionAccount { get; set; }
        public string GltransactionDescription { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public decimal? GldebitAmount { get; set; }
        public decimal? GlcreditAmount { get; set; }
        public string ProjectId { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string GlanalysisType1 { get; set; }
        public string GlanalysisType2 { get; set; }
        public string CorrespondingAccount { get; set; }
        public bool? Sync { get; set; }
        public DateTime? SyncDate { get; set; }
        public DateTime? GltransactionDate { get; set; }
        public string BranchCode { get; set; }
    }
}
