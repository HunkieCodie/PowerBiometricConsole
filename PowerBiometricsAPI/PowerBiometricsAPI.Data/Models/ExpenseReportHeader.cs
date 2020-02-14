using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class ExpenseReportHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string ExpenseReportId { get; set; }
        public string ExpenseReportType { get; set; }
        public DateTime? ExpenseReportDate { get; set; }
        public string ExpenseReportForEmployee { get; set; }
        public string ExpenseReportReason { get; set; }
        public string ExpenseReportDescription { get; set; }
        public decimal? ExpenseReportTotal { get; set; }
        public decimal? ExpenseReportAdvances { get; set; }
        public decimal? ExpenseReportDueEmployee { get; set; }
        public bool? ExpenseReportPaid { get; set; }
        public DateTime? ExpenseReportPaidDate { get; set; }
        public string ExpenseReportPaymentId { get; set; }
        public bool? ExpenseReportApproved { get; set; }
        public string ExpenseReportApprovedBy { get; set; }
        public DateTime? ExpenseReportApprovedDate { get; set; }
        public string ExpenseReportMemo1 { get; set; }
        public string ExpenseReportMemo2 { get; set; }
        public string ExpenseReportMemo3 { get; set; }
        public string ExpenseReportMemo4 { get; set; }
        public string ExpenseReportMemo5 { get; set; }
        public string ExpenseReportMemo6 { get; set; }
        public string ExpenseReportMemo7 { get; set; }
        public string ExpenseReportMemo8 { get; set; }
        public string ExpenseReportMemo9 { get; set; }
        public string ExpenseReportMemo10 { get; set; }
        public string Signature { get; set; }
        public string SignaturePassword { get; set; }
        public string SupervisorSignature { get; set; }
        public string SupervisorPassword { get; set; }
        public string ManagerSignature { get; set; }
        public string ManagerPassword { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
