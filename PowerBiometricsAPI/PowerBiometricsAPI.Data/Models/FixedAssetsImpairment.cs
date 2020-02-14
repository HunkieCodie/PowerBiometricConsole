using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class FixedAssetsImpairment
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string AssetId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Reference { get; set; }
        public string Notes { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public double? AssetBookValue { get; set; }
        public double? RecoverableAmount { get; set; }
        public double? ImpairedAmount { get; set; }
        public string GlfixedAssetProfitOrLossAccount { get; set; }
        public string GlfixedRevaluationableAccount { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string EnteredBy { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? Posted { get; set; }
        public string ProjectId { get; set; }
        public string BranchCode { get; set; }
    }
}
