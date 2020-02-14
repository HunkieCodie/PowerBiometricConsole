using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class Warehouses
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public string WarehouseAddress1 { get; set; }
        public string WarehouseAddress2 { get; set; }
        public string WarehouseAddress3 { get; set; }
        public string WarehouseCity { get; set; }
        public string WarehouseState { get; set; }
        public string WarehouseZip { get; set; }
        public string WarehousePhone { get; set; }
        public string WarehouseFax { get; set; }
        public string WarehouseEmail { get; set; }
        public string WarehouseWebPage { get; set; }
        public string WarehouseAttention { get; set; }
        public string RoutingContactName { get; set; }
        public string RoutingAddressd { get; set; }
        public string RoutingContactPhone { get; set; }
        public string RoutingContactFax { get; set; }
        public string RoutingContactEmail { get; set; }
        public string StockControlAccount { get; set; }
        public string PackId { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string SalesControlAccount { get; set; }
        public string CoscontrolAccount { get; set; }
        public string CustomerId { get; set; }
        public bool? Active { get; set; }
        public string BranchCode { get; set; }
    }
}
