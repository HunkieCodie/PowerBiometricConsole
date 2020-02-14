using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class HelpSupportRequestDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public long CaseId { get; set; }
        public string Subject { get; set; }
        public DateTime? Created { get; set; }
        public string Message { get; set; }
        public string ScreenShotUrl { get; set; }
        public string LockedBy { get; set; }
        public string LockTs { get; set; }
        public long CaseIddetail { get; set; }
        public string BranchCode { get; set; }
    }
}
