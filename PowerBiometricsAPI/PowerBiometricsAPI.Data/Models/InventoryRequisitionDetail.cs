using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class InventoryRequisitionDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string Id { get; set; }
        public string ItemId { get; set; }
        public DateTime? DateOfTransaction { get; set; }
        public double? Quantity { get; set; }
        public int AutoNumber { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
