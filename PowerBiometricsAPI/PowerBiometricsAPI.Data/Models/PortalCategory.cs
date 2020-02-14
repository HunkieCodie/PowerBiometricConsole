using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PortalCategory
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PortalId { get; set; }
        public string PortalCategory1 { get; set; }
        public string PortalCategoryName { get; set; }
        public string PortalCategoryDescription { get; set; }
        public string PortalCategoryLongDescription { get; set; }
        public string PortalCategoryLogoUrl { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
