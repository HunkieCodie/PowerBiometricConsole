using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class Portal
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PortalId { get; set; }
        public string PortalName { get; set; }
        public string PortalShortDescription { get; set; }
        public string PortalLongDescription { get; set; }
        public string PortalUrl { get; set; }
        public string PortalLogoUrl { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
