using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PortalAdvertising
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PortalId { get; set; }
        public string BannerId { get; set; }
        public string CustomerId { get; set; }
        public bool? LimitToCategory { get; set; }
        public string Category { get; set; }
        public bool? LimitToSubCategory { get; set; }
        public string SubCategory { get; set; }
        public string BannerUrl { get; set; }
        public string BannerType { get; set; }
        public string Description { get; set; }
        public long? NumberOfDisplays { get; set; }
        public long? NumberOfClicks { get; set; }
        public DateTime? RotationStarted { get; set; }
        public DateTime? RotationStopped { get; set; }
        public long? NumberOfDisplaysPurchased { get; set; }
        public long? NumberOfClicksPurchased { get; set; }
        public DateTime? DisplayUntilDate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
