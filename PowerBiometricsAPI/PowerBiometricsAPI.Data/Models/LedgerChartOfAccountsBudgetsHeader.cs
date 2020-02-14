using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class LedgerChartOfAccountsBudgetsHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string GlbudgetId { get; set; }
        public string GlbudgetNotes { get; set; }
        public bool? GlbudgetActive { get; set; }
        public int? GlfiscalYear { get; set; }
        public double? GlbudgetAmount { get; set; }
        public int? NumberofPeriod { get; set; }
        public bool? Cleared { get; set; }
        public DateTime? ClearedDate { get; set; }
        public string ClearedBy { get; set; }
        public bool? Void { get; set; }
        public bool? Approved { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApprovedBy { get; set; }
        public bool? Posted { get; set; }
        public DateTime? PostedDate { get; set; }
        public string PostedBy { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
