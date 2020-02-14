using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class FixedAssetType
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string AssetTypeId { get; set; }
        public string AssetTypeDescription { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string GlfixedAssetAccount { get; set; }
        public string GlfixedDepreciationAccount { get; set; }
        public string GlfixedAccumDepreciationAccount { get; set; }
        public string GlfixedDisposalAccount { get; set; }
        public string BranchCode { get; set; }
    }
}
