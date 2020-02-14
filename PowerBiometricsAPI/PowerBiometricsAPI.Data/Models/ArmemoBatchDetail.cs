using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class ArmemoBatchDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string BatchNumber { get; set; }
        public decimal BatchLineNumber { get; set; }
        public string CustomerId { get; set; }
        public string GlcustomerAccount { get; set; }
        public string GltransactionAccount { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public decimal? TransactionAmount { get; set; }
        public string Description { get; set; }
        public string ProjectId { get; set; }
        public string GlanalysisType1 { get; set; }
        public string GlanalysisType2 { get; set; }
        public string AssetId { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public double? UnallocatedAmount { get; set; }
        public double? AllocatedAmount { get; set; }
        public string PaymentId { get; set; }
        public DateTime? PaidDate { get; set; }
        public string CustomerName { get; set; }
        public string BranchCode { get; set; }
    }
}
