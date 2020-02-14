using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class WarehousesBilling
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string WarehouseId { get; set; }
        public string ItemId { get; set; }
        public double? Amount { get; set; }
        public bool? Taxable { get; set; }
        public string TaxGroupId { get; set; }
        public double? Rate { get; set; }
        public string ProjectId { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
