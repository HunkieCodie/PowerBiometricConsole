using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class LedgerChartOfAccountsBudgetsDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string GlbudgetId { get; set; }
        public string GlaccountNumber { get; set; }
        public string ProjectId { get; set; }
        public decimal? GlbudgetAmount { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string GlanalysisType { get; set; }
        public string GlanalysisType2 { get; set; }
        public string BranchCode { get; set; }
    }
}
