using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class TblVersionHistory
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string VersionId { get; set; }
        public string RegCode { get; set; }
        public string Remarks { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string RegName { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public string BranchCode { get; set; }
    }
}
