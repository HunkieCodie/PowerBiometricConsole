using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class InventorySerialNumbersHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ItemId { get; set; }
        public string PurchaseNumber { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseBinId { get; set; }
        public DateTime? DateReceived { get; set; }
        public double? OriginalLotOrderQty { get; set; }
        public double? CurrentLotOrderQty { get; set; }
        public DateTime? LotManufacturedDate { get; set; }
        public DateTime? LotExpirationDate { get; set; }
        public string SerialNumberComment { get; set; }
        public string SerialNumber { get; set; }
        public bool? Received { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public double? OutstandingQty { get; set; }
        public double? UsedQty { get; set; }
        public string BranchCode { get; set; }
    }
}
