using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class Boqdetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string Boqnumber { get; set; }
        public decimal BoqlineNumber { get; set; }
        public string ItemId { get; set; }
        public string ItemUpccode { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseBinId { get; set; }
        public double? OrderQty { get; set; }
        public decimal? ItemMarketCost { get; set; }
        public decimal? ItemDeliveredCost { get; set; }
        public decimal? ItemFixedCost { get; set; }
        public string TaxGroupId { get; set; }
        public decimal? TaxAmount { get; set; }
        public double? TaxPercent { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Total { get; set; }
        public string GlsalesAccount { get; set; }
        public string Glcogaccount { get; set; }
        public string ProjectId { get; set; }
        public string GlanalysisType1 { get; set; }
        public string GlanalysisType2 { get; set; }
        public string AssetId { get; set; }
        public string ItemUom { get; set; }
        public string DetailMemo1 { get; set; }
        public string DetailMemo2 { get; set; }
        public string DetailMemo3 { get; set; }
        public string DetailMemo4 { get; set; }
        public string DetailMemo5 { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? MarkFixedCost { get; set; }
        public bool? MarkDeliveredCost { get; set; }
        public decimal? ItemFixedCostValue { get; set; }
        public decimal? ItemDeliveredCostValue { get; set; }
        public string BranchCode { get; set; }
    }
}
