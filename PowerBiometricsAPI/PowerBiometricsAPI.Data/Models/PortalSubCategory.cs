using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PortalSubCategory
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PortalId { get; set; }
        public string PortalCategory { get; set; }
        public string PortalSubCategory1 { get; set; }
        public string PortalSubCategoryName { get; set; }
        public string PortalSubCategoryDescription { get; set; }
        public string PortalSubCategoryLongDescription { get; set; }
        public string PortalSubCategoryLogoUrl { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
