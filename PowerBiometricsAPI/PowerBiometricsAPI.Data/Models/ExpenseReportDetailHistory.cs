using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class ExpenseReportDetailHistory
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ExpenseReportId { get; set; }
        public long ExpenseReporDetailId { get; set; }
        public string ExpenseReportItemId { get; set; }
        public string ExpenseReportDetailDescription { get; set; }
        public string ExpenseReportDetailAmount { get; set; }
        public string ExpenseReportDetailUnits { get; set; }
        public decimal? ExpenseReportDetailTotal { get; set; }
        public bool? ExpenseReportReceiptProvided { get; set; }
        public string ExpenseReportReceiptId { get; set; }
        public string ExpenseReportDetailMemo1 { get; set; }
        public string ExpenseReportDetailMemo2 { get; set; }
        public string ExpenseReportDetailMemo3 { get; set; }
        public string ExpenseReportDetailMemo4 { get; set; }
        public string ExpenseReportDetailMemo5 { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
