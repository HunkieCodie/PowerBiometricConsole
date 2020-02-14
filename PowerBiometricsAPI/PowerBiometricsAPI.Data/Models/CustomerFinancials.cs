using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class CustomerFinancials
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string CustomerId { get; set; }
        public decimal? AvailibleCredit { get; set; }
        public short? LateDays { get; set; }
        public short? AverageDaytoPay { get; set; }
        public DateTime? LastPaymentDate { get; set; }
        public decimal? LastPaymentAmount { get; set; }
        public decimal? HighestCredit { get; set; }
        public decimal? HighestBalance { get; set; }
        public double? PromptPerc { get; set; }
        public decimal? BookedOrders { get; set; }
        public decimal? AdvertisingDollars { get; set; }
        public decimal? TotalAr { get; set; }
        public decimal? CurrentArbalance { get; set; }
        public decimal? Under30 { get; set; }
        public decimal? Over30 { get; set; }
        public decimal? Over60 { get; set; }
        public decimal? Over90 { get; set; }
        public decimal? Over120 { get; set; }
        public decimal? Over150 { get; set; }
        public decimal? Over180 { get; set; }
        public decimal? SalesYtd { get; set; }
        public decimal? SalesLastYear { get; set; }
        public decimal? SalesLifetime { get; set; }
        public DateTime? LastSalesDate { get; set; }
        public decimal? PaymentsLastYear { get; set; }
        public decimal? PaymentsLifetime { get; set; }
        public decimal? PaymentsYtd { get; set; }
        public decimal? WriteOffsYtd { get; set; }
        public decimal? WriteOffsLastYear { get; set; }
        public decimal? WriteOffsLifetime { get; set; }
        public decimal? InvoicesYtd { get; set; }
        public decimal? InvoicesLastYear { get; set; }
        public decimal? InvoicesLifetime { get; set; }
        public decimal? CreditMemos { get; set; }
        public DateTime? LastCreditMemoDate { get; set; }
        public decimal? CreditMemosYtd { get; set; }
        public decimal? CreditMemosLastYear { get; set; }
        public decimal? CreditMemosLifetime { get; set; }
        public decimal? Rmas { get; set; }
        public DateTime? LastRmadate { get; set; }
        public decimal? RmasYtd { get; set; }
        public decimal? RmasLastYear { get; set; }
        public decimal? RmasLifetime { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
