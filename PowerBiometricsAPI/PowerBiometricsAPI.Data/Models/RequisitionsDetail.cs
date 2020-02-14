using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class RequisitionsDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string RequisitionId { get; set; }
        public decimal RequisitionDetailId { get; set; }
        public string DocumentNumber { get; set; }
        public string DocumentName { get; set; }
        public string WarehouseId { get; set; }
        public string WarehouseBinId { get; set; }
        public string Description { get; set; }
        public double? Quantity { get; set; }
        public double? Price { get; set; }
        public double? SubTotal { get; set; }
        public double? Total { get; set; }
        public string ProjectId { get; set; }
        public string LockedBy { get; set; }
        public string LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
