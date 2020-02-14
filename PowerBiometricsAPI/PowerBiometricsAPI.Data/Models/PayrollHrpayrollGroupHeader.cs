using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollGroupHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string GroupId { get; set; }
        public string GroupDescription { get; set; }
        public int? Frequency { get; set; }
        public int? LeaveDays { get; set; }
        public decimal? Amount { get; set; }
        public string GlaccountNumber { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string NextGroupId { get; set; }
        public string BranchCode { get; set; }
    }
}
