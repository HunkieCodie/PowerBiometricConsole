using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class InventorySerialNumbersDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ItemId { get; set; }
        public string PurchaseNumber { get; set; }
        public string SerialNumber { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseBinId { get; set; }
        public string OrderNumber { get; set; }
        public short? OrderLineNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public short? InvoiceLineNumber { get; set; }
        public DateTime? DateSold { get; set; }
        public bool? IsSold { get; set; }
        public string SerialNumberComment { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? Posted { get; set; }
        public string DocumentType { get; set; }
        public string ReverseDocumentNumber { get; set; }
        public string BranchCode { get; set; }
    }
}
