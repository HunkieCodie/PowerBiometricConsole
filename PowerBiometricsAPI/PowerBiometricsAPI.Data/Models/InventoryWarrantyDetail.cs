using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class InventoryWarrantyDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ItemId { get; set; }
        public string InvoiceNumber { get; set; }
        public int? InvoiceLineNumber { get; set; }
        public string SerialNumber { get; set; }
        public string OrderNumber { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseBinId { get; set; }
        public int? WarrantyPeriod { get; set; }
        public DateTime? WarrantyStartDate { get; set; }
        public DateTime? WarrantyEndDate { get; set; }
        public string WarrantyStatus { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
