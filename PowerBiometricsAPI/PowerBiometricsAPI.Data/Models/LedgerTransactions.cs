using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class LedgerTransactions
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string GltransactionNumber { get; set; }
        public string GltransactionTypeId { get; set; }
        public DateTime? GltransactionDate { get; set; }
        public DateTime? SystemDate { get; set; }
        public string GltransactionDescription { get; set; }
        public string GltransactionReference { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public decimal? GltransactionAmount { get; set; }
        public decimal? GltransactionAmountUndistributed { get; set; }
        public decimal? GltransactionBalance { get; set; }
        public bool? GltransactionPostedYn { get; set; }
        public string GltransactionSource { get; set; }
        public bool? GltransactionSystemGenerated { get; set; }
        public bool? GltransactionRecurringYn { get; set; }
        public bool? Reversal { get; set; }
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
        public bool? Memorize { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string Reference { get; set; }
        public DateTime? EntryDate { get; set; }
        public bool? Sync { get; set; }
        public DateTime? SyncDate { get; set; }
        public string BranchCode { get; set; }
    }
}
