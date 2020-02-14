using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class ExpenseReportItems
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ExpenseReportItemId { get; set; }
        public string ExpenseReportItemDescription { get; set; }
        public string ExpsneseReportGlaccount { get; set; }
        public decimal? ExpenseReportMilageRate { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
