using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class InventorySerialNumbers
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ItemId { get; set; }
        public string SerialNumber { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public decimal PurchaseOrderLineNumber { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseBinId { get; set; }
        public string OrderNumber { get; set; }
        public short? OrderLineNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public short? InvoiceLineNumber { get; set; }
        public DateTime? DateReceived { get; set; }
        public int? OriginalLotOrderQty { get; set; }
        public int? CurrentLotOrderQty { get; set; }
        public DateTime? LotExpirationDate { get; set; }
        public string SerialNumberComment { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
