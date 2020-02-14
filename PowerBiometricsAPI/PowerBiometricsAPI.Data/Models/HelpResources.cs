using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class HelpResources
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ResourceId { get; set; }
        public string ResourceType { get; set; }
        public string ResourceProductId { get; set; }
        public int? ResourceRank { get; set; }
        public string ResourceLink { get; set; }
        public string ResourceDescription { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
