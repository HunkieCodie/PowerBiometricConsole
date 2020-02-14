using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollAppraisalKeyDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string Department { get; set; }
        public string GroupId { get; set; }
        public string AppraisalGoalId { get; set; }
        public decimal AppraisalKeyResultInc { get; set; }
        public string AppraisalKeyResultId { get; set; }
        public string AppraisalKeyResultIndicator { get; set; }
        public double? Point { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
