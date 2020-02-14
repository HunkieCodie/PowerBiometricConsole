using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollAppraisalHistoryHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PeriodId { get; set; }
        public string AppraisalId { get; set; }
        public string AppraisalName { get; set; }
        public string Department { get; set; }
        public string GroupId { get; set; }
        public string AppraiseeId { get; set; }
        public double? TotalScore { get; set; }
        public double? MaxScore { get; set; }
        public double? Percentage { get; set; }
        public string Remark { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? EnteredDate { get; set; }
        public bool? Cleared { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public bool? Posted { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
        public bool? ReviewStatus { get; set; }
        public bool? Reviewed { get; set; }
        public string AppraisalReviewHistoryId { get; set; }
        public string ReviewedBy { get; set; }
        public DateTime? ReviewedDate { get; set; }
    }
}
