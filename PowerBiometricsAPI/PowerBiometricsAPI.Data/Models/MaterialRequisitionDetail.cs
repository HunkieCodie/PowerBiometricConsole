using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class MaterialRequisitionDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string MaterialRequisitionId { get; set; }
        public decimal MaterialRequisitionDetailId { get; set; }
        public string ItemId { get; set; }
        public string Description { get; set; }
        public double? RequestedQty { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseBinId { get; set; }
        public string ToWarehouseId { get; set; }
        public string ToWarehouseBinId { get; set; }
        public string GlexpenseAccount { get; set; }
        public decimal? ItemValue { get; set; }
        public decimal? ItemCost { get; set; }
        public string CostMethod { get; set; }
        public string ProjectId { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string GlanalysisType1 { get; set; }
        public string GlanalysisType2 { get; set; }
        public string AssetId { get; set; }
        public string TaxGroupId { get; set; }
        public string MultipleDiscountGroupId { get; set; }
        public decimal? MultipleDiscountAmount { get; set; }
        public double? MultipleDiscountPercent { get; set; }
        public string Ponumber { get; set; }
        public string ItemUpccode { get; set; }
        public string BranchCode { get; set; }
    }
}
