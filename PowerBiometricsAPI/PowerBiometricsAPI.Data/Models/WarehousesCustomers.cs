using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class WarehousesCustomers
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseCustomerId { get; set; }
        public string CustomerId { get; set; }
        public string WarehouseCustomerName { get; set; }
        public string WarehouseCustomerAddress1 { get; set; }
        public string WarehouseCustomerAddress2 { get; set; }
        public string WarehouseCustomerAddress3 { get; set; }
        public string WarehouseCustomerCity { get; set; }
        public string WarehouseCustomerState { get; set; }
        public string WarehouseCustomerZip { get; set; }
        public string WarehouseCustomerPhone { get; set; }
        public string WarehouseCustomerFax { get; set; }
        public string WarehouseCustomerEmail { get; set; }
        public string WarehouseCustomerWebPage { get; set; }
        public string WarehouseCustomerAttention { get; set; }
        public string WarehouseCustomerContact { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
