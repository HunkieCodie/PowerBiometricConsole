using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollAppraisalDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PeriodId { get; set; }
        public string AppraisalId { get; set; }
        public decimal AppraisalDetailInc { get; set; }
        public string AppraisalType { get; set; }
        public string AppraisalGoal { get; set; }
        public string AppraisalKeyResultId { get; set; }
        public string AppraisalKeyResultIndicator { get; set; }
        public double? MaxScore { get; set; }
        public double? AppraiseeScore { get; set; }
        public double? AppraisalScore { get; set; }
        public string Remarks { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public double? AppraiseePercent { get; set; }
        public string ScoreCriteriaId { get; set; }
        public string BranchCode { get; set; }
        public double? ReviewedAppraisalScore { get; set; }
    }
}
