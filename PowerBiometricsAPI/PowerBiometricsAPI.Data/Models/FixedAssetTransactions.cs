using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class FixedAssetTransactions
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string AssetId { get; set; }
        public string TransactionTypeId { get; set; }
        public decimal AssetTransactionDetailId { get; set; }
        public string GltransactionAccount { get; set; }
        public string Notes { get; set; }
        public DateTime? TransactionDate { get; set; }
        public double? TransactionAmount { get; set; }
        public bool? Posted { get; set; }
        public string PostedBy { get; set; }
        public DateTime? PostedDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
