using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollAppraisalCategory
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PeriodId { get; set; }
        public string AppraisalId { get; set; }
        public string CriteriaId { get; set; }
        public string AppraisalTypeId { get; set; }
        public double? MaxScore { get; set; }
        public double? AppraiseeScore { get; set; }
        public string Remarks { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
