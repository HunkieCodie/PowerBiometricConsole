using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class InventoryAdjustmentsDetailBatch
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string AdjustmentId { get; set; }
        public decimal AdjustmentLineId { get; set; }
        public string ItemId { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseBinId { get; set; }
        public string AdjustmentDescription { get; set; }
        public double? OriginalQuantity { get; set; }
        public double? AdjustedQuantity { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public decimal? Cost { get; set; }
        public string GladjustmentPostingAccount { get; set; }
        public string ProjectId { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public double? UnitCost { get; set; }
        public string BranchCode { get; set; }
    }
}
