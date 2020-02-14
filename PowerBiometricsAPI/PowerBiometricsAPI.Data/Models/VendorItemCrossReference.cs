using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class VendorItemCrossReference
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string VendorId { get; set; }
        public string VendorItemId { get; set; }
        public string VendorItemDescription { get; set; }
        public string ItemId { get; set; }
        public string ItemDescription { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
