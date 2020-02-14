using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PortalNews
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PortalId { get; set; }
        public string PortalNewsId { get; set; }
        public string PortalNewsTitle { get; set; }
        public DateTime? PortalNewsDate { get; set; }
        public string PortalNewsMessage { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
