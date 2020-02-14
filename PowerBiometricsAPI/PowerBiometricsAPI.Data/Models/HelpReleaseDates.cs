using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class HelpReleaseDates
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ProductName { get; set; }
        public string CurrentVersion { get; set; }
        public string NextVersion { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Notes { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
