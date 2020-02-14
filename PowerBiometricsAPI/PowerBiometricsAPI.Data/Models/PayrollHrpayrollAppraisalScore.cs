using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PayrollHrpayrollAppraisalScore
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public decimal ScoreId { get; set; }
        public string ScoreDescription { get; set; }
        public string ScoreCriteriaId { get; set; }
        public double? ScorePercentage { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
