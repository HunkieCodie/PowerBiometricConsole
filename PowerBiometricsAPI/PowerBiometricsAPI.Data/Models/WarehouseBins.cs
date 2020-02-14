using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class WarehouseBins
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseBinId { get; set; }
        public string WarehouseBinName { get; set; }
        public string WarehouseBinNumber { get; set; }
        public string WarehouseBinZone { get; set; }
        public string WarehouseBinType { get; set; }
        public string WarehouseBinLocation { get; set; }
        public string WarehouseBinLocationX { get; set; }
        public string WarehouseBinLocationY { get; set; }
        public string WarehouseBinLocationZ { get; set; }
        public string WarehouseBinLength { get; set; }
        public string WarehouseBinWidth { get; set; }
        public string WarehouseBinHeight { get; set; }
        public long? WarehouseBinWeight { get; set; }
        public string WarehouseBinRfid { get; set; }
        public double? MinimumQuantity { get; set; }
        public double? MaximumQuantity { get; set; }
        public string OverFlowBin { get; set; }
        public bool? LockerStock { get; set; }
        public double? LockerStockQty { get; set; }
        public string ResponsiblePerson { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? Active { get; set; }
        public bool? Transport { get; set; }
        public string BranchCode { get; set; }
    }
}
