using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PortalResources
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PortalId { get; set; }
        public string PortalResourceId { get; set; }
        public string PortalCategory { get; set; }
        public string PortalSubCategory { get; set; }
        public string PortalResourceType { get; set; }
        public string PortalResourceName { get; set; }
        public string PortalResourceDescription { get; set; }
        public string PortalResourcePictureUrl { get; set; }
        public string PortalResourceLinkUrl { get; set; }
        public string PortalResourceDownloadUrl { get; set; }
        public string PortalResourcePrice { get; set; }
        public bool? PortalResourceValidated { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
